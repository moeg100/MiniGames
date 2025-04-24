using Guessing_Game;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Guessing_Game.Tests
{
    [TestClass()]
    public class MainFormTests
    {

        private MainForm _mainForm;

        [TestInitialize]
        public void Setup()
        {
            _mainForm = new MainForm(); 
        }

        Words keywords = new Words();

        [TestMethod()]
        public void MainFormTestWordsClass()
        {
            
            // Assert
            List<string> randomKeyWords = new List<string> {"Dog", "Cat", "Sedan", "Truck", "Candy"};


            // Act

            keywords.SetWord("Ball");
            keywords.SetWord("Sport");
            keywords.SetWord("GPU");
   
            keywords.SetWords(randomKeyWords);

            // Arrange

            foreach(string word in randomKeyWords)
            {
                Assert.IsTrue(keywords.GetWords().Contains(word.ToLower()), $"Expected '{word}' to be in the list of keywords.");

            }
        }

        [TestMethod()]
        public void InitializeGame_ShouldInitializeCorrectly()
        {
            // Act
            _mainForm.InitializeGame();

            // Assert
            Assert.IsNotNull(_mainForm);  
            Assert.AreEqual(6, _mainForm.attemptsLeft);  
            Assert.IsNotNull(_mainForm.wordToGuess); 
            Assert.IsTrue(_mainForm.displayedWord.All(c => c == '_'));  
        }

        [TestMethod()]
        public void WordEval_ShouldEndGame_WhenWordIsGuessed()
        {
            // Arrange
            _mainForm.InitializeGame();
            _mainForm.wordToGuess = "apple";
            _mainForm.displayedWord = new char[] { '_', '_', '_', '_', '_' };
            _mainForm.attemptsLeft = 6;

            // Act
            _mainForm.TxtGuessText = "a";
            _mainForm.wordEval();
            _mainForm.TxtGuessText = "p";
            _mainForm.wordEval();
            _mainForm.TxtGuessText = "l";
            _mainForm.wordEval();
            _mainForm.TxtGuessText = "e";
            _mainForm.wordEval();

            // Assert
            Assert.AreEqual("apple", new string(_mainForm.displayedWord));
            Assert.AreEqual(6, _mainForm.attemptsLeft);  
        }


        [TestMethod()]
        public void WordEval_ShouldHandleIncorrectGuess()
        {
            // Arrange
            _mainForm.InitializeGame();
            string incorrectGuess = "z";
            _mainForm.TxtGuessText = incorrectGuess;

            // Act
            _mainForm.wordEval();

            // Assert
            Assert.IsTrue(_mainForm.incorrectGuesses.Contains('z'));  
            Assert.AreEqual(5, _mainForm.attemptsLeft);  
        }

        [TestMethod]
        public void wordEval_ShouldCorrectlyEvaluateCorrectGuess()
        {
            // Arrange
            string correctGuess = _mainForm.wordToGuess[0].ToString();
            _mainForm.TxtGuessText = correctGuess;

            // Act
            _mainForm.wordEval();

            // Assert
            Assert.IsTrue(new string(_mainForm.displayedWord).Contains(correctGuess)); 
            Assert.AreEqual(6, _mainForm.attemptsLeft); 
        }



    }
}