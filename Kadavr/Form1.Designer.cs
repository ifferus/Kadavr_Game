﻿namespace Kadavr
{
    partial class Kadavr_Game
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
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.updateBackground = new System.Windows.Forms.Timer(this.components);
            this.CordX = new System.Windows.Forms.Label();
            this.CordY = new System.Windows.Forms.Label();
            this.moveBulletsTimer_Tick = new System.Windows.Forms.Timer(this.components);
            this.Score = new System.Windows.Forms.Label();
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.hpBar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // updateBackground
            // 
            this.updateBackground.Enabled = true;
            this.updateBackground.Interval = 60;
            this.updateBackground.Tick += new System.EventHandler(this.updateBackground_Tick);
            // 
            // CordX
            // 
            this.CordX.AutoSize = true;
            this.CordX.BackColor = System.Drawing.Color.Transparent;
            this.CordX.Location = new System.Drawing.Point(1077, 57);
            this.CordX.Name = "CordX";
            this.CordX.Size = new System.Drawing.Size(38, 15);
            this.CordX.TabIndex = 0;
            this.CordX.Text = "label1";
            // 
            // CordY
            // 
            this.CordY.AutoSize = true;
            this.CordY.BackColor = System.Drawing.Color.Transparent;
            this.CordY.Location = new System.Drawing.Point(1080, 90);
            this.CordY.Name = "CordY";
            this.CordY.Size = new System.Drawing.Size(38, 15);
            this.CordY.TabIndex = 1;
            this.CordY.Text = "label1";
            // 
            // moveBulletsTimer_Tick
            // 
            this.moveBulletsTimer_Tick.Enabled = true;
            this.moveBulletsTimer_Tick.Interval = 25;
            this.moveBulletsTimer_Tick.Tick += new System.EventHandler(this.moveBulletsTimer_Tick_Tick);
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.BackColor = System.Drawing.Color.Transparent;
            this.Score.Location = new System.Drawing.Point(907, 54);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(38, 15);
            this.Score.TabIndex = 2;
            this.Score.Text = "label1";
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.AutoSize = true;
            this.gameOverLabel.BackColor = System.Drawing.Color.Transparent;
            this.gameOverLabel.Font = new System.Drawing.Font("Showcard Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gameOverLabel.ForeColor = System.Drawing.Color.Red;
            this.gameOverLabel.Location = new System.Drawing.Point(333, 90);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(574, 119);
            this.gameOverLabel.TabIndex = 3;
            this.gameOverLabel.Text = "GAME OVER";
            this.gameOverLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.gameOverLabel.Visible = false;
            // 
            // hpBar
            // 
            this.hpBar.AutoSize = true;
            this.hpBar.BackColor = System.Drawing.Color.Transparent;
            this.hpBar.Location = new System.Drawing.Point(986, 54);
            this.hpBar.Name = "hpBar";
            this.hpBar.Size = new System.Drawing.Size(38, 15);
            this.hpBar.TabIndex = 4;
            this.hpBar.Text = "label1";
            // 
            // Kadavr_Game
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.hpBar);
            this.Controls.Add(this.gameOverLabel);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.CordY);
            this.Controls.Add(this.CordX);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "Kadavr_Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kadavr";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Kadavr_Game_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Kadavr_Game_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Kadavr_Game_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer updateBackground;
        private Label CordX;
        private Label CordY;
        private System.Windows.Forms.Timer moveBulletsTimer_Tick;
        private Label Score;
        private Label gameOverLabel;
        private Label hpBar;
    }
}