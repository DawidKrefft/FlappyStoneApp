
namespace FlappyStone
{
    partial class Form1
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
            this.ScoreText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.GameMenu = new System.Windows.Forms.GroupBox();
            this.LblQuit = new System.Windows.Forms.Label();
            this.LblRestart = new System.Windows.Forms.Label();
            this.ground = new System.Windows.Forms.PictureBox();
            this.FlappyStone = new System.Windows.Forms.PictureBox();
            this.FirstTopObstacle = new System.Windows.Forms.PictureBox();
            this.SecondTopObstacle = new System.Windows.Forms.PictureBox();
            this.SecondBottomObstacle = new System.Windows.Forms.PictureBox();
            this.FirstBottomObstacle = new System.Windows.Forms.PictureBox();
            this.HighScoreText = new System.Windows.Forms.Label();
            this.HighScoreValue = new System.Windows.Forms.Label();
            this.ResetHighScore = new System.Windows.Forms.Label();
            this.GameMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlappyStone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstTopObstacle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondTopObstacle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondBottomObstacle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstBottomObstacle)).BeginInit();
            this.SuspendLayout();
            // 
            // ScoreText
            // 
            this.ScoreText.AutoSize = true;
            this.ScoreText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ScoreText.Font = new System.Drawing.Font("Liberation Sans", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreText.Location = new System.Drawing.Point(12, 72);
            this.ScoreText.Name = "ScoreText";
            this.ScoreText.Size = new System.Drawing.Size(166, 41);
            this.ScoreText.TabIndex = 4;
            this.ScoreText.Text = "Score: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // GameMenu
            // 
            this.GameMenu.BackColor = System.Drawing.Color.LimeGreen;
            this.GameMenu.BackgroundImage = global::FlappyStone.Properties.Resources.stone;
            this.GameMenu.Controls.Add(this.ResetHighScore);
            this.GameMenu.Controls.Add(this.LblQuit);
            this.GameMenu.Controls.Add(this.LblRestart);
            this.GameMenu.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GameMenu.Location = new System.Drawing.Point(92, 187);
            this.GameMenu.Name = "GameMenu";
            this.GameMenu.Size = new System.Drawing.Size(403, 254);
            this.GameMenu.TabIndex = 5;
            this.GameMenu.TabStop = false;
            this.GameMenu.Text = "Menu";
            this.GameMenu.Enter += new System.EventHandler(this.GameMenu_Enter);
            // 
            // LblQuit
            // 
            this.LblQuit.AutoSize = true;
            this.LblQuit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblQuit.Font = new System.Drawing.Font("Alef", 24F, System.Drawing.FontStyle.Bold);
            this.LblQuit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblQuit.Location = new System.Drawing.Point(150, 145);
            this.LblQuit.Name = "LblQuit";
            this.LblQuit.Size = new System.Drawing.Size(88, 43);
            this.LblQuit.TabIndex = 2;
            this.LblQuit.Text = "Quit";
            this.LblQuit.Click += new System.EventHandler(this.LblQuit_Click_1);
            // 
            // LblRestart
            // 
            this.LblRestart.AutoSize = true;
            this.LblRestart.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblRestart.Font = new System.Drawing.Font("Alef", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRestart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblRestart.Location = new System.Drawing.Point(124, 62);
            this.LblRestart.Name = "LblRestart";
            this.LblRestart.Size = new System.Drawing.Size(138, 43);
            this.LblRestart.TabIndex = 0;
            this.LblRestart.Text = "Restart";
            this.LblRestart.Click += new System.EventHandler(this.LblRestart_Click);
            // 
            // ground
            // 
            this.ground.Image = global::FlappyStone.Properties.Resources.stone;
            this.ground.Location = new System.Drawing.Point(-12, 586);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(1306, 137);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // FlappyStone
            // 
            this.FlappyStone.Image = global::FlappyStone.Properties.Resources.stone;
            this.FlappyStone.Location = new System.Drawing.Point(83, 316);
            this.FlappyStone.Name = "FlappyStone";
            this.FlappyStone.Size = new System.Drawing.Size(52, 50);
            this.FlappyStone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FlappyStone.TabIndex = 2;
            this.FlappyStone.TabStop = false;
            // 
            // FirstTopObstacle
            // 
            this.FirstTopObstacle.Image = global::FlappyStone.Properties.Resources.stone;
            this.FirstTopObstacle.Location = new System.Drawing.Point(739, -43);
            this.FirstTopObstacle.Name = "FirstTopObstacle";
            this.FirstTopObstacle.Size = new System.Drawing.Size(100, 264);
            this.FirstTopObstacle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FirstTopObstacle.TabIndex = 1;
            this.FirstTopObstacle.TabStop = false;
            // 
            // SecondTopObstacle
            // 
            this.SecondTopObstacle.Image = global::FlappyStone.Properties.Resources.stone;
            this.SecondTopObstacle.Location = new System.Drawing.Point(1070, -28);
            this.SecondTopObstacle.Name = "SecondTopObstacle";
            this.SecondTopObstacle.Size = new System.Drawing.Size(100, 278);
            this.SecondTopObstacle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SecondTopObstacle.TabIndex = 0;
            this.SecondTopObstacle.TabStop = false;
            // 
            // SecondBottomObstacle
            // 
            this.SecondBottomObstacle.Image = global::FlappyStone.Properties.Resources.stone;
            this.SecondBottomObstacle.Location = new System.Drawing.Point(891, 390);
            this.SecondBottomObstacle.Name = "SecondBottomObstacle";
            this.SecondBottomObstacle.Size = new System.Drawing.Size(100, 249);
            this.SecondBottomObstacle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SecondBottomObstacle.TabIndex = 6;
            this.SecondBottomObstacle.TabStop = false;
            // 
            // FirstBottomObstacle
            // 
            this.FirstBottomObstacle.Image = global::FlappyStone.Properties.Resources.stone;
            this.FirstBottomObstacle.Location = new System.Drawing.Point(597, 343);
            this.FirstBottomObstacle.Name = "FirstBottomObstacle";
            this.FirstBottomObstacle.Size = new System.Drawing.Size(100, 296);
            this.FirstBottomObstacle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FirstBottomObstacle.TabIndex = 7;
            this.FirstBottomObstacle.TabStop = false;
            // 
            // HighScoreText
            // 
            this.HighScoreText.AutoSize = true;
            this.HighScoreText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.HighScoreText.Font = new System.Drawing.Font("Liberation Sans", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighScoreText.Location = new System.Drawing.Point(12, 20);
            this.HighScoreText.Name = "HighScoreText";
            this.HighScoreText.Size = new System.Drawing.Size(218, 41);
            this.HighScoreText.TabIndex = 8;
            this.HighScoreText.Text = "HighScore:";
            // 
            // HighScoreValue
            // 
            this.HighScoreValue.AutoSize = true;
            this.HighScoreValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.HighScoreValue.Font = new System.Drawing.Font("Liberation Sans", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighScoreValue.Location = new System.Drawing.Point(236, 20);
            this.HighScoreValue.Name = "HighScoreValue";
            this.HighScoreValue.Size = new System.Drawing.Size(39, 41);
            this.HighScoreValue.TabIndex = 9;
            this.HighScoreValue.Text = "0";
            // 
            // ResetHighScore
            // 
            this.ResetHighScore.AutoSize = true;
            this.ResetHighScore.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ResetHighScore.Font = new System.Drawing.Font("Alef", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetHighScore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ResetHighScore.Location = new System.Drawing.Point(291, 225);
            this.ResetHighScore.Name = "ResetHighScore";
            this.ResetHighScore.Size = new System.Drawing.Size(106, 16);
            this.ResetHighScore.TabIndex = 3;
            this.ResetHighScore.Text = "Reset High Score";
            this.ResetHighScore.Click += new System.EventHandler(this.ResetHighScore_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::FlappyStone.Properties.Resources.skyMinimalist;
            this.ClientSize = new System.Drawing.Size(570, 671);
            this.Controls.Add(this.HighScoreValue);
            this.Controls.Add(this.HighScoreText);
            this.Controls.Add(this.GameMenu);
            this.Controls.Add(this.FirstBottomObstacle);
            this.Controls.Add(this.SecondBottomObstacle);
            this.Controls.Add(this.ScoreText);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.FlappyStone);
            this.Controls.Add(this.FirstTopObstacle);
            this.Controls.Add(this.SecondTopObstacle);
            this.Name = "Form1";
            this.Text = "FlappyStone";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameKeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameKeyIsUp);
            this.GameMenu.ResumeLayout(false);
            this.GameMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlappyStone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstTopObstacle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondTopObstacle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondBottomObstacle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstBottomObstacle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox SecondTopObstacle;
        private System.Windows.Forms.PictureBox FirstTopObstacle;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label ScoreText;
        private System.Windows.Forms.PictureBox FlappyStone;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.GroupBox GameMenu;
        private System.Windows.Forms.Label LblRestart;
        private System.Windows.Forms.Label LblQuit;
        private System.Windows.Forms.PictureBox SecondBottomObstacle;
        private System.Windows.Forms.PictureBox FirstBottomObstacle;
        private System.Windows.Forms.Label HighScoreText;
        private System.Windows.Forms.Label HighScoreValue;
        private System.Windows.Forms.Label ResetHighScore;
    }
}

