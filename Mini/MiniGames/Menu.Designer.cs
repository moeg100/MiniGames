namespace MiniGames
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            labelMiniGame = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(543, 235);
            button1.Name = "button1";
            button1.Size = new Size(202, 170);
            button1.TabIndex = 0;
            button1.Text = "Guessing Word";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(45, 235);
            button2.Name = "button2";
            button2.Size = new Size(202, 170);
            button2.TabIndex = 1;
            button2.Text = "Escape";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // labelMiniGame
            // 
            labelMiniGame.AutoSize = true;
            labelMiniGame.Font = new Font("Segoe UI Semibold", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMiniGame.Location = new Point(213, 21);
            labelMiniGame.Name = "labelMiniGame";
            labelMiniGame.Size = new Size(382, 86);
            labelMiniGame.TabIndex = 2;
            labelMiniGame.Text = "Mini Games";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(labelMiniGame);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Menu";
            Text = "MiniGames";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label labelMiniGame;
    }
}
