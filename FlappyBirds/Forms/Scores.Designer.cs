
namespace FlappyBirds
{
    partial class Scores
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
            this.ListScores = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // ListScores
            // 
            this.ListScores.HideSelection = false;
            this.ListScores.Location = new System.Drawing.Point(35, 65);
            this.ListScores.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ListScores.Name = "ListScores";
            this.ListScores.Size = new System.Drawing.Size(279, 452);
            this.ListScores.TabIndex = 0;
            this.ListScores.UseCompatibleStateImageBehavior = false;
            this.ListScores.SelectedIndexChanged += new System.EventHandler(this.Scores_SelectedIndexChanged);
            // 
            // Scores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(349, 588);
            this.Controls.Add(this.ListScores);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Scores";
            this.Text = "Scores";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ListScores;
    }
}