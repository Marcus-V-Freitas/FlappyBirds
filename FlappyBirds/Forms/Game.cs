using FlappyBirds.Class;
using FlappyBirds.Utils;
using System;
using System.Windows.Forms;

namespace FlappyBirds
{
    public partial class Game : Form
    {
        private int pipeSpeed = 8;
        private int gravity = 8;
        private int score = 0;

        public string PlayerName { get; private set; }

        public Game()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            Bird.Top += gravity;
            PipeDown.Left -= pipeSpeed;
            pipeUp.Left -= pipeSpeed;

            if (PipeDown.Left < -80)
            {
                PipeDown.Left = 800;
                score++;
                Score.Text = "Score: " + score.ToString();
            }
            if (pipeUp.Left < -110)
            {
                pipeUp.Left = 950;
                score++;
                Score.Text = "Score: " + score.ToString();
            }

            if (Bird.Bounds.IntersectsWith(PipeDown.Bounds) || Bird.Bounds.IntersectsWith(pipeUp.Bounds) || Bird.Bounds.IntersectsWith(Ground.Bounds))
            {
                endGame();
            }
        }

        internal void SetPlayerName(string playerName)
        {
            PlayerName = playerName;
        }

        private void endGame()
        {
            gameTimer.Stop();
            ScoreUtils.WriteScore(new PlayerScore { Score = score, Name = PlayerName });
            Score.Text = "Game Over! Your score is: " + score;
            this.Close();
        }

        private void gameKeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -5;
            }
        }

        private void gameKeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }
    }
}