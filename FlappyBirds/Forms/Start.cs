using System;
using System.Windows.Forms;

namespace FlappyBirds
{
    public partial class Start : Form
    {
        private string PlayerName = "Marcus";

        public Start()
        {
            InitializeComponent();
            TextBoxName.Text = PlayerName;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            game.SetPlayerName(PlayerName);
            game.Show();
        }

        private void Controls_Click(object sender, EventArgs e)
        {
            Controls controls = new Controls();
            controls.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Scores_Click(object sender, EventArgs e)
        {
            Scores scores = new Scores();
            scores.Show();
            scores.SetScores();
        }

        private void Name_Leave(object sender, EventArgs e)
        {
            PlayerName = TextBoxName.Text;
        }
    }
}