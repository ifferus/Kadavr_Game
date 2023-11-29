namespace Kadavr
{
    partial class Form2
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
            this.gameStartButton = new System.Windows.Forms.Button();
            this.gameSettingsButton = new System.Windows.Forms.Button();
            this.gameRattingButton = new System.Windows.Forms.Button();
            this.gameExitButton = new System.Windows.Forms.Button();
            this.hardLevelButton = new System.Windows.Forms.Button();
            this.mediumLevelButton = new System.Windows.Forms.Button();
            this.labelLevel = new System.Windows.Forms.Label();
            this.easyLevelButton = new System.Windows.Forms.Button();
            this.panelSetting = new System.Windows.Forms.Panel();
            this.panelSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameStartButton
            // 
            this.gameStartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gameStartButton.Location = new System.Drawing.Point(590, 350);
            this.gameStartButton.Name = "gameStartButton";
            this.gameStartButton.Size = new System.Drawing.Size(100, 50);
            this.gameStartButton.TabIndex = 1;
            this.gameStartButton.Text = "Start";
            this.gameStartButton.UseVisualStyleBackColor = false;
            this.gameStartButton.Click += new System.EventHandler(this.gameStartButton_Click);
            // 
            // gameSettingsButton
            // 
            this.gameSettingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gameSettingsButton.Location = new System.Drawing.Point(600, 410);
            this.gameSettingsButton.Name = "gameSettingsButton";
            this.gameSettingsButton.Size = new System.Drawing.Size(80, 40);
            this.gameSettingsButton.TabIndex = 2;
            this.gameSettingsButton.Text = "Settings";
            this.gameSettingsButton.UseVisualStyleBackColor = false;
            this.gameSettingsButton.Click += new System.EventHandler(this.gameSettingsButton_Click);
            // 
            // gameRattingButton
            // 
            this.gameRattingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gameRattingButton.Location = new System.Drawing.Point(502, 460);
            this.gameRattingButton.Name = "gameRattingButton";
            this.gameRattingButton.Size = new System.Drawing.Size(80, 40);
            this.gameRattingButton.TabIndex = 3;
            this.gameRattingButton.Text = "Rating";
            this.gameRattingButton.UseVisualStyleBackColor = false;
            this.gameRattingButton.Visible = false;
            this.gameRattingButton.Click += new System.EventHandler(this.gameRattingButton_Click);
            // 
            // gameExitButton
            // 
            this.gameExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gameExitButton.Location = new System.Drawing.Point(600, 460);
            this.gameExitButton.Name = "gameExitButton";
            this.gameExitButton.Size = new System.Drawing.Size(80, 40);
            this.gameExitButton.TabIndex = 4;
            this.gameExitButton.Text = "Exit";
            this.gameExitButton.UseVisualStyleBackColor = false;
            this.gameExitButton.Click += new System.EventHandler(this.gameExitButton_Click);
            // 
            // hardLevelButton
            // 
            this.hardLevelButton.Location = new System.Drawing.Point(7, 160);
            this.hardLevelButton.Name = "hardLevelButton";
            this.hardLevelButton.Size = new System.Drawing.Size(80, 40);
            this.hardLevelButton.TabIndex = 7;
            this.hardLevelButton.Text = "Hard";
            this.hardLevelButton.UseVisualStyleBackColor = true;
            this.hardLevelButton.Click += new System.EventHandler(this.hardLevelButton_Click);
            // 
            // mediumLevelButton
            // 
            this.mediumLevelButton.Location = new System.Drawing.Point(7, 110);
            this.mediumLevelButton.Name = "mediumLevelButton";
            this.mediumLevelButton.Size = new System.Drawing.Size(80, 40);
            this.mediumLevelButton.TabIndex = 6;
            this.mediumLevelButton.Text = "Medium";
            this.mediumLevelButton.UseVisualStyleBackColor = true;
            this.mediumLevelButton.Click += new System.EventHandler(this.mediumLevelButton_Click);
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.BackColor = System.Drawing.Color.Transparent;
            this.labelLevel.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLevel.ForeColor = System.Drawing.Color.Red;
            this.labelLevel.Location = new System.Drawing.Point(7, 16);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(87, 17);
            this.labelLevel.TabIndex = 8;
            this.labelLevel.Text = "Level Game";
            this.labelLevel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelLevel.Click += new System.EventHandler(this.labelLevel_Click);
            // 
            // easyLevelButton
            // 
            this.easyLevelButton.Location = new System.Drawing.Point(7, 60);
            this.easyLevelButton.Name = "easyLevelButton";
            this.easyLevelButton.Size = new System.Drawing.Size(80, 40);
            this.easyLevelButton.TabIndex = 5;
            this.easyLevelButton.Text = "Easy";
            this.easyLevelButton.UseVisualStyleBackColor = true;
            this.easyLevelButton.Click += new System.EventHandler(this.easyLevelButton_Click);
            // 
            // panelSetting
            // 
            this.panelSetting.BackColor = System.Drawing.Color.Transparent;
            this.panelSetting.Controls.Add(this.labelLevel);
            this.panelSetting.Controls.Add(this.mediumLevelButton);
            this.panelSetting.Controls.Add(this.easyLevelButton);
            this.panelSetting.Controls.Add(this.hardLevelButton);
            this.panelSetting.Location = new System.Drawing.Point(696, 350);
            this.panelSetting.Name = "panelSetting";
            this.panelSetting.Size = new System.Drawing.Size(193, 224);
            this.panelSetting.TabIndex = 9;
            this.panelSetting.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelSetting);
            this.Controls.Add(this.gameExitButton);
            this.Controls.Add(this.gameRattingButton);
            this.Controls.Add(this.gameSettingsButton);
            this.Controls.Add(this.gameStartButton);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Kadavr_Menu_Paint);
            this.panelSetting.ResumeLayout(false);
            this.panelSetting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button gameStartButton;
        private Button gameSettingsButton;
        private Button gameRattingButton;
        private Button gameExitButton;
        private Button hardLevelButton;
        private Button mediumLevelButton;
        private Label labelLevel;
        private Button easyLevelButton;
        private Panel panelSetting;
    }
}