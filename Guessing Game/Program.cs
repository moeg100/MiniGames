using System;
using System.Windows.Forms;
using Guessing_Game;

namespace LetterGuessingGame
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm()); // Ensure "Form1" matches your main form's name
        }
    }
}