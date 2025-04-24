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
            this.components = new System.ComponentModel.Container();
            this.lblWord = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.btnGuess = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.lblAttempts = new System.Windows.Forms.Label();
            this.lstIncorrectGuesses = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Location = new System.Drawing.Point(107, 73);
            this.lblWord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(49, 13);
            this.lblWord.TabIndex = 0;
            this.lblWord.Text = "_ _ _ _ _";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtGuess
            // 
            this.txtGuess.Location = new System.Drawing.Point(110, 175);
            this.txtGuess.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGuess.MaxLength = 1;
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(39, 20);
            this.txtGuess.TabIndex = 2;
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(167, 175);
            this.btnGuess.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(56, 19);
            this.btnGuess.TabIndex = 3;
            this.btnGuess.Text = "Submit";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(34, 282);
            this.btnNewGame.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(98, 36);
            this.btnNewGame.TabIndex = 4;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // lblAttempts
            // 
            this.lblAttempts.AutoSize = true;
            this.lblAttempts.Location = new System.Drawing.Point(188, 304);
            this.lblAttempts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAttempts.Name = "lblAttempts";
            this.lblAttempts.Size = new System.Drawing.Size(77, 13);
            this.lblAttempts.TabIndex = 5;
            this.lblAttempts.Text = "Attempts left: 6";
            // 
            // lstIncorrectGuesses
            // 
            this.lstIncorrectGuesses.FormattingEnabled = true;
            this.lstIncorrectGuesses.Location = new System.Drawing.Point(262, 27);
            this.lstIncorrectGuesses.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstIncorrectGuesses.Name = "lstIncorrectGuesses";
            this.lstIncorrectGuesses.Size = new System.Drawing.Size(91, 134);
            this.lstIncorrectGuesses.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lstIncorrectGuesses);
            this.Controls.Add(this.lblAttempts);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.lblWord);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Label lblAttempts;
        private System.Windows.Forms.ListBox lstIncorrectGuesses;
    }
}

