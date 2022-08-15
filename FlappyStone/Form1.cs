using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace FlappyStone
{
    public partial class Form1 : Form
    {

        int obstacleSpeed = 20;
        int gravity = 1;
        int score = 0;
        public SoundPlayer soundPlayer;

        public Form1()
        {
            InitializeComponent();
            GameMenu.Hide();
            HighScoreValue.Text = Properties.Settings.Default.h_score;

        }


        private void GameTimerEvent(object sender, EventArgs e)
        {
            FlappyStone.Top += gravity;
            FirstTopObstacle.Left -= obstacleSpeed;
            FirstBottomObstacle.Left -= obstacleSpeed;
            SecondTopObstacle.Left -= obstacleSpeed;
            SecondBottomObstacle.Left -= obstacleSpeed;
            ScoreText.Text = "Score " + score;


            if (FirstBottomObstacle.Left < -150)
            {
                FirstBottomObstacle.Left = 600;
                score++;
            }
            
            if (SecondBottomObstacle.Left < -165)
            {
                SecondBottomObstacle.Left = 750;
                score++;
            }
            
            if (FirstTopObstacle.Left < -155)
            {
                FirstTopObstacle.Left = 700;
                score++;
            }
            
            if (SecondTopObstacle.Left < -170)
            {
                SecondTopObstacle.Left = 850;
                score++;
            }
            


            if (FlappyStone.Bounds.IntersectsWith(FirstBottomObstacle.Bounds) ||
                FlappyStone.Bounds.IntersectsWith(SecondBottomObstacle.Bounds) ||
                FlappyStone.Bounds.IntersectsWith(FirstTopObstacle.Bounds) ||
                FlappyStone.Bounds.IntersectsWith(SecondTopObstacle.Bounds) ||
                FlappyStone.Bounds.IntersectsWith(ground.Bounds) ||
                FlappyStone.Top < -25)
            {
                EndGame();
            }
        }


        private void GameKeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }
            
            //soundPlayer = new SoundPlayer(@"C:\...\point.wav"); //paste your path for a sound effect
            //soundPlayer.Play();                                 //and uncomment these 2 lines
        }

        private void GameKeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 20;
            }
        }

        private void EndGame()
        {
            gameTimer.Stop();
            int a = Int32.Parse(HighScoreValue.Text);
            if (score>a)
            {
                HighScoreValue.Text = score.ToString();
                Properties.Settings.Default.h_score = HighScoreValue.Text;
                Properties.Settings.Default.Save();
            }
            ScoreText.Text += " Game over";
            GameMenu.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LblQuit_Click(object sender, EventArgs e)
        {

        }

        private void GameMenu_Enter(object sender, EventArgs e)
        {

        }

        private void LblRestart_Click(object sender, EventArgs e)
        {
            gameTimer.Start();
            GameMenu.Hide();

            FlappyStone.Location = new Point(83, 316);

            FirstBottomObstacle.Location = new Point(597, 343);
            SecondBottomObstacle.Location = new Point(891, 390);

            FirstTopObstacle.Location = new Point(739, -43);
            SecondTopObstacle.Location = new Point(1070, -28);

            score = 0;
            ScoreText.Text = "Score: 0";

        }

        private void LblQuit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ResetHighScore_Click(object sender, EventArgs e)
        {
            int resetValue = 0;
            HighScoreValue.Text = resetValue.ToString();
            Properties.Settings.Default.Save();
        }
    }
}
