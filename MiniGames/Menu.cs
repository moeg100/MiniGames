using System.Diagnostics;
using Guessing_Game;

namespace MiniGames
{
    public partial class Menu : Form
    {



        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainGame = new MainForm();
            mainGame.ShowDialog();
         

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TEST");

            try
            {
               
                string consoleAppPath = Path.Combine(Application.StartupPath, "ConsoleApp3.exe");
                System.Diagnostics.Process.Start(consoleAppPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error launching the console app: " + ex.Message);
            }


        }
    }
}
