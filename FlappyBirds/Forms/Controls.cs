using System;
using System.Windows.Forms;

namespace FlappyBirds
{
    public partial class Controls : Form
    {
        public Controls()
        {
            InitializeComponent();
        }

        private void GoBack_Click(object sender, EventArgs e)
        {
            this.close();
        }
    }
}