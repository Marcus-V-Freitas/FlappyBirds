
namespace FlappyBirds
{
    partial class Start
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
            this.ButtonStart = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.LabelPlay = new System.Windows.Forms.Label();
            this.ButtonControls = new System.Windows.Forms.Button();
            this.ButtonScores = new System.Windows.Forms.Button();
            this.Cloud1 = new System.Windows.Forms.PictureBox();
            this.Cloud3 = new System.Windows.Forms.PictureBox();
            this.Cloud2 = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.PictureBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Cloud1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cloud3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cloud2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Title)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonStart
            // 
            this.ButtonStart.BackColor = System.Drawing.Color.LimeGreen;
            this.ButtonStart.Location = new System.Drawing.Point(68, 258);
            this.ButtonStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(231, 82);
            this.ButtonStart.TabIndex = 0;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = false;
            this.ButtonStart.Click += new System.EventHandler(this.Start_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.BackColor = System.Drawing.Color.LimeGreen;
            this.ButtonExit.Location = new System.Drawing.Point(755, 258);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(231, 82);
            this.ButtonExit.TabIndex = 1;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = false;
            this.ButtonExit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // LabelPlay
            // 
            this.LabelPlay.AutoSize = true;
            this.LabelPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.LabelPlay.Location = new System.Drawing.Point(49, 206);
            this.LabelPlay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelPlay.Name = "LabelPlay";
            this.LabelPlay.Size = new System.Drawing.Size(267, 31);
            this.LabelPlay.TabIndex = 6;
            this.LabelPlay.Text = "Press Start to Play!";
            // 
            // ButtonControls
            // 
            this.ButtonControls.BackColor = System.Drawing.Color.LimeGreen;
            this.ButtonControls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonControls.Location = new System.Drawing.Point(416, 535);
            this.ButtonControls.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonControls.Name = "ButtonControls";
            this.ButtonControls.Size = new System.Drawing.Size(231, 82);
            this.ButtonControls.TabIndex = 7;
            this.ButtonControls.Text = "Controls";
            this.ButtonControls.UseVisualStyleBackColor = false;
            this.ButtonControls.Click += new System.EventHandler(this.Controls_Click);
            // 
            // ButtonScores
            // 
            this.ButtonScores.BackColor = System.Drawing.Color.LimeGreen;
            this.ButtonScores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonScores.Location = new System.Drawing.Point(416, 258);
            this.ButtonScores.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonScores.Name = "ButtonScores";
            this.ButtonScores.Size = new System.Drawing.Size(231, 82);
            this.ButtonScores.TabIndex = 8;
            this.ButtonScores.Text = "Scores";
            this.ButtonScores.UseVisualStyleBackColor = false;
            this.ButtonScores.Click += new System.EventHandler(this.Scores_Click);
            // 
            // Cloud1
            // 
            this.Cloud1.Image = global::FlappyBirds.Resource.cloud;
            this.Cloud1.Location = new System.Drawing.Point(416, 378);
            this.Cloud1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cloud1.Name = "Cloud1";
            this.Cloud1.Size = new System.Drawing.Size(235, 105);
            this.Cloud1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cloud1.TabIndex = 5;
            this.Cloud1.TabStop = false;
            // 
            // Cloud3
            // 
            this.Cloud3.Image = global::FlappyBirds.Resource.cloud;
            this.Cloud3.Location = new System.Drawing.Point(697, 535);
            this.Cloud3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cloud3.Name = "Cloud3";
            this.Cloud3.Size = new System.Drawing.Size(235, 105);
            this.Cloud3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cloud3.TabIndex = 4;
            this.Cloud3.TabStop = false;
            // 
            // Cloud2
            // 
            this.Cloud2.Image = global::FlappyBirds.Resource.cloud;
            this.Cloud2.Location = new System.Drawing.Point(56, 488);
            this.Cloud2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cloud2.Name = "Cloud2";
            this.Cloud2.Size = new System.Drawing.Size(235, 105);
            this.Cloud2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cloud2.TabIndex = 3;
            this.Cloud2.TabStop = false;
            // 
            // Title
            // 
            this.Title.Image = global::FlappyBirds.Resource.download;
            this.Title.Location = new System.Drawing.Point(68, 18);
            this.Title.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(917, 143);
            this.Title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Title.TabIndex = 2;
            this.Title.TabStop = false;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelName.Location = new System.Drawing.Point(80, 378);
            this.LabelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(170, 31);
            this.LabelName.TabIndex = 9;
            this.LabelName.Text = "Insert Name:";
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(68, 426);
            this.TextBoxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(220, 27);
            this.TextBoxName.TabIndex = 10;
            this.TextBoxName.Leave += new System.EventHandler(this.Name_Leave);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1067, 692);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.ButtonScores);
            this.Controls.Add(this.ButtonControls);
            this.Controls.Add(this.LabelPlay);
            this.Controls.Add(this.Cloud1);
            this.Controls.Add(this.Cloud3);
            this.Controls.Add(this.Cloud2);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.ButtonStart);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Start";
            this.Text = "Start";
            ((System.ComponentModel.ISupportInitialize)(this.Cloud1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cloud3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cloud2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Title)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.PictureBox Title;
        private System.Windows.Forms.PictureBox Cloud2;
        private System.Windows.Forms.PictureBox Cloud3;
        private System.Windows.Forms.PictureBox Cloud1;
        private System.Windows.Forms.Label LabelPlay;
        private System.Windows.Forms.Button ButtonControls;
        private System.Windows.Forms.Button ButtonScores;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.TextBox TextBoxName;
    }
}