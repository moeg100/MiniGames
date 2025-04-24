namespace Guessing_Game
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblWord = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtGuess = new TextBox();
            btnGuess = new Button();
            btnNewGame = new Button();
            lblAttempts = new Label();
            lstIncorrectGuesses = new ListBox();
            rbEasy = new RadioButton();
            rbNormal = new RadioButton();
            rbHard = new RadioButton();
            SuspendLayout();
            // 
            // lblWord
            // 
            lblWord.AutoSize = true;
            lblWord.Location = new Point(125, 84);
            lblWord.Margin = new Padding(2, 0, 2, 0);
            lblWord.Name = "lblWord";
            lblWord.Size = new Size(44, 15);
            lblWord.TabIndex = 0;
            lblWord.Text = "_ _ _ _ _";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtGuess
            // 
            txtGuess.Location = new Point(128, 202);
            txtGuess.Margin = new Padding(2);
            txtGuess.MaxLength = 1;
            txtGuess.Name = "txtGuess";
            txtGuess.Size = new Size(45, 23);
            txtGuess.TabIndex = 2;
            // 
            // btnGuess
            // 
            btnGuess.Location = new Point(195, 202);
            btnGuess.Margin = new Padding(2);
            btnGuess.Name = "btnGuess";
            btnGuess.Size = new Size(65, 22);
            btnGuess.TabIndex = 3;
            btnGuess.Text = "Submit";
            btnGuess.UseVisualStyleBackColor = true;
            btnGuess.Click += btnGuess_Click;
            // 
            // btnNewGame
            // 
            btnNewGame.Location = new Point(40, 325);
            btnNewGame.Margin = new Padding(2);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(114, 42);
            btnNewGame.TabIndex = 4;
            btnNewGame.Text = "New Game";
            btnNewGame.UseVisualStyleBackColor = true;
            btnNewGame.Click += btnNewGame_Click;
            // 
            // lblAttempts
            // 
            lblAttempts.AutoSize = true;
            lblAttempts.Location = new Point(219, 351);
            lblAttempts.Margin = new Padding(2, 0, 2, 0);
            lblAttempts.Name = "lblAttempts";
            lblAttempts.Size = new Size(88, 15);
            lblAttempts.TabIndex = 5;
            lblAttempts.Text = "Attempts left: 6";
            // 
            // lstIncorrectGuesses
            // 
            lstIncorrectGuesses.FormattingEnabled = true;
            lstIncorrectGuesses.ItemHeight = 15;
            lstIncorrectGuesses.Location = new Point(306, 31);
            lstIncorrectGuesses.Margin = new Padding(2);
            lstIncorrectGuesses.Name = "lstIncorrectGuesses";
            lstIncorrectGuesses.Size = new Size(106, 154);
            lstIncorrectGuesses.TabIndex = 6;
            // 
            // rbEasy
            // 
            rbEasy.AutoSize = true;
            rbEasy.Location = new Point(553, 57);
            rbEasy.Name = "rbEasy";
            rbEasy.Size = new Size(48, 19);
            rbEasy.TabIndex = 7;
            rbEasy.TabStop = true;
            rbEasy.Text = "Easy";
            rbEasy.UseVisualStyleBackColor = true;
            rbEasy.CheckedChanged += rbEasy_CheckedChanged;
            // 
            // rbNormal
            // 
            rbNormal.AutoSize = true;
            rbNormal.Location = new Point(553, 93);
            rbNormal.Name = "rbNormal";
            rbNormal.Size = new Size(65, 19);
            rbNormal.TabIndex = 8;
            rbNormal.TabStop = true;
            rbNormal.Text = "Normal";
            rbNormal.UseVisualStyleBackColor = true;
            rbNormal.CheckedChanged += rbNormal_CheckedChanged;
            // 
            // rbHard
            // 
            rbHard.AutoSize = true;
            rbHard.Location = new Point(553, 133);
            rbHard.Name = "rbHard";
            rbHard.Size = new Size(51, 19);
            rbHard.TabIndex = 9;
            rbHard.TabStop = true;
            rbHard.Text = "Hard";
            rbHard.UseVisualStyleBackColor = true;
            rbHard.CheckedChanged += rbHard_CheckedChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 422);
            Controls.Add(rbHard);
            Controls.Add(rbNormal);
            Controls.Add(rbEasy);
            Controls.Add(lstIncorrectGuesses);
            Controls.Add(lblAttempts);
            Controls.Add(btnNewGame);
            Controls.Add(btnGuess);
            Controls.Add(txtGuess);
            Controls.Add(lblWord);
            Margin = new Padding(2);
            Name = "MainForm";
            Text = "Guessing Game";
            FormClosing += MainForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Label lblAttempts;
        private System.Windows.Forms.ListBox lstIncorrectGuesses;
        private RadioButton rbEasy;
        private RadioButton rbNormal;
        private RadioButton rbHard;
    }
}

