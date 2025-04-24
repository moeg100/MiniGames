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
     public List<string> words = new List<string> {
    "fork", "lamp", "moon", "tree", "code",         
    "apple", "water", "table", "liver", "grass",    
    "orange", "bottle", "snake", "planet", "coffee",
    "forest", "singer", "number", "doctor", "wizard", 
    "sunshine", "journey", "diamond", "heavens", "bubble"
};

        public Words keywords;
        public string wordToGuess;
        public char[] displayedWord;
        public int attemptsLeft = 6;
        public List<char> incorrectGuesses = new List<char>();


        public string TxtGuessText
        {
            get { return txtGuess.Text; }
            set { txtGuess.Text = value; }
        }


        public MainForm()
        {
            InitializeComponent();
            InitializeGame();
        }

        public void InitializeGame()
        {
            try
            {
                keywords = new Words(words);
                Debug.WriteLine($"THE LENGTH IS :  {keywords.GetWords().Count}");
                if (keywords.GetWords().Count == 0)
                {
                    throw new InvalidOperationException("No valid words available to play.");
                }

                wordToGuess = keywords.RandomWord();

                displayedWord = new char[wordToGuess.Length];
                for (int i = 0; i < displayedWord.Length; i++)
                {
                    displayedWord[i] = '_';
                }

                attemptsLeft = 6;
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
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }

        public void wordEval()
        {
            if (txtGuess.Text.Length == 0 || !char.IsLetter(txtGuess.Text[0]))
            {
                MessageBox.Show("Please enter a valid letter.");
                return;
            }
            char guess = char.ToLower(txtGuess.Text[0]);
            bool isCorrect = false;

            for (int i = 0; i < wordToGuess.Length; i++)
            {
                if (wordToGuess[i] == guess)
                {
                    displayedWord[i] = guess;
                    isCorrect = true;
                }
            }

            if (!isCorrect)
            {
                incorrectGuesses.Add(guess);
                lstIncorrectGuesses.Items.Add(guess);
                attemptsLeft--;
                lblAttempts.Text = $"Attempts left: {attemptsLeft}";
            }

            lblWord.Text = string.Join(" ", displayedWord);

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

        private void btnGuess_Click(object sender, EventArgs e)
        {
            wordEval();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            InitializeGame();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
