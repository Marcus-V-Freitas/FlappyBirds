using FlappyBirds.Utils;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace FlappyBirds
{
    public partial class Scores : Form
    {
        public Scores()
        {
            InitializeComponent();
        }

        public void SetScores()
        {
            var items = ScoreUtils.ReadTopScores()
                .Select(item => new ListViewItem(item.ToString()))
                .ToArray();

            ListScores.Items.AddRange(items);
        }

        private void Scores_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}