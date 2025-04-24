using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guessing_Game
{
    public partial class MainForm : Form
    {
        // Define difficulty levels
        public enum Difficulty { Easy, Normal, Hard }
        private Difficulty currentDifficulty = Difficulty.Normal;

        // Word lists for different difficulties
        private Dictionary<Difficulty, List<string>> wordLists = new Dictionary<Difficulty, List<string>>()
        {
            { Difficulty.Easy, new List<string> { "fork", "lamp", "moon", "tree", "code", "apple", "water", "table", "liver", "grass", "orange", "bottle", "snake", "planet", "coffee" } },
            { Difficulty.Normal, new List<string> { "singer", "number", "doctor", "wizard", "sunshine", "journey", "diamond", "heavens", "bubble", "forest", "elephant", "giraffe", "kangaroo", "library" } },
            { Difficulty.Hard, new List<string> { "mountain", "notebook", "octopus", "parrot", "rainbow", "strawberry", "telescope", "umbrella", "volcano", "watermelon", "xylophone", "zeppelin", "alligator", "basketball" } }
        };

        private string wordToGuess;
        private char[] displayedWord;
        private int attemptsLeft;
        private List<char> incorrectGuesses = new List<char>();

        // Constructor
        public MainForm()
        {
            InitializeComponent();
            InitializeGame();
        }

        // Initialize the game with the selected difficulty level
        public void InitializeGame()
        {
            try
            {
                // Select the appropriate word list based on the current difficulty
                List<string> currentWordList = wordLists[currentDifficulty];

                // Check if the word list for the current difficulty is empty
                if (currentWordList.Count == 0)
                {
                    throw new InvalidOperationException("No valid words available to play.");
                }

                // Choose a random word from the list
                Random random = new Random();
                wordToGuess = currentWordList[random.Next(currentWordList.Count)];

                // Initialize the displayed word
                displayedWord = new char[wordToGuess.Length];
                for (int i = 0; i < displayedWord.Length; i++)
                {
                    displayedWord[i] = '_';
                }

                // Set the number of attempts based on difficulty
                if (currentDifficulty == Difficulty.Easy)
                    attemptsLeft = 5;
                else if (currentDifficulty == Difficulty.Normal)
                    attemptsLeft = 7;
                else // Hard
                    attemptsLeft = 9;

                // Reset the game state
                incorrectGuesses.Clear();
                lblWord.Text = string.Join(" ", displayedWord);
                lblAttempts.Text = $"Attempts left: {attemptsLeft}";
                lstIncorrectGuesses.Items.Clear();
                txtGuess.Clear();
                txtGuess.Enabled = true;
                btnGuess.Enabled = true;
            }
            catch (Exception ex)
            {
                // Show an error message if something goes wrong
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // You can optionally exit or close the game here if needed
                // Environment.Exit(0);   // Un-comment this if you want the game to exit on error
            }
        }

        // Method to evaluate the guessed letter
        public void wordEval()
        {
            // Validate input
            if (txtGuess.Text.Length == 0 || !char.IsLetter(txtGuess.Text[0]))
            {
                MessageBox.Show("Please enter a valid letter.");
                return;
            }

            char guess = char.ToLower(txtGuess.Text[0]);
            bool isCorrect = false;

            // Check if the guessed letter is in the word
            for (int i = 0; i < wordToGuess.Length; i++)
            {
                if (wordToGuess[i] == guess)
                {
                    displayedWord[i] = guess;
                    isCorrect = true;
                }
            }

            // Handle incorrect guess
            if (!isCorrect)
            {
                incorrectGuesses.Add(guess);
                lstIncorrectGuesses.Items.Add(guess);
                attemptsLeft--;
                lblAttempts.Text = $"Attempts left: {attemptsLeft}";
            }

            // Update the displayed word
            lblWord.Text = string.Join(" ", displayedWord);

            // Check for win/lose
            if (new string(displayedWord) == wordToGuess)
            {
                MessageBox.Show($"You won! The word was: {wordToGuess}");
                txtGuess.Enabled = false;
                btnGuess.Enabled = false;
            }
            else if (attemptsLeft == 0)
            {
                MessageBox.Show($"You lost! The word was: {wordToGuess}");
                txtGuess.Enabled = false;
                btnGuess.Enabled = false;
            }

            txtGuess.Clear();
        }

        // Event handler for the "Guess" button
        private void btnGuess_Click(object sender, EventArgs e)
        {
            wordEval();
        }

        // Event handler for the "New Game" button
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            InitializeGame();
        }

        // Event handlers for difficulty selection
        private void rbEasy_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEasy.Checked)
            {
                currentDifficulty = Difficulty.Easy;
                InitializeGame();
            }
        }

        private void rbNormal_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNormal.Checked)
            {
                currentDifficulty = Difficulty.Normal;
                InitializeGame();
            }
        }

        private void rbHard_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHard.Checked)
            {
                currentDifficulty = Difficulty.Hard;
                InitializeGame();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();




            this.Hide();


            Form menuForm = Application.OpenForms["Menu"];
            if (menuForm != null)
            {
                menuForm.Show();
            }
        }

    }
}
