
namespace FlappyBirds
{
    partial class Controls
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
            this.LabelControls = new System.Windows.Forms.Label();
            this.LabelInstruction1 = new System.Windows.Forms.Label();
            this.LabelInstruction2 = new System.Windows.Forms.Label();
            this.LabelInstruction4 = new System.Windows.Forms.Label();
            this.LabelInstruction5 = new System.Windows.Forms.Label();
            this.LabelInstruction3 = new System.Windows.Forms.Label();
            this.ButtonGoBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelControls
            // 
            this.LabelControls.AutoSize = true;
            this.LabelControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.LabelControls.ForeColor = System.Drawing.Color.Black;
            this.LabelControls.Location = new System.Drawing.Point(84, 55);
            this.LabelControls.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelControls.Name = "LabelControls";
            this.LabelControls.Size = new System.Drawing.Size(144, 36);
            this.LabelControls.TabIndex = 0;
            this.LabelControls.Text = "Controls:";
            // 
            // LabelInstruction1
            // 
            this.LabelInstruction1.AutoSize = true;
            this.LabelInstruction1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.LabelInstruction1.Location = new System.Drawing.Point(-4, 129);
            this.LabelInstruction1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelInstruction1.Name = "LabelInstruction1";
            this.LabelInstruction1.Size = new System.Drawing.Size(297, 20);
            this.LabelInstruction1.TabIndex = 1;
            this.LabelInstruction1.Text = "> Press the Space button to go up";
            // 
            // LabelInstruction2
            // 
            this.LabelInstruction2.AutoSize = true;
            this.LabelInstruction2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.LabelInstruction2.Location = new System.Drawing.Point(-4, 202);
            this.LabelInstruction2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelInstruction2.Name = "LabelInstruction2";
            this.LabelInstruction2.Size = new System.Drawing.Size(282, 20);
            this.LabelInstruction2.TabIndex = 2;
            this.LabelInstruction2.Text = ">You get one point for each pipe";
            // 
            // LabelInstruction4
            // 
            this.LabelInstruction4.AutoSize = true;
            this.LabelInstruction4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.LabelInstruction4.Location = new System.Drawing.Point(-4, 286);
            this.LabelInstruction4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelInstruction4.Name = "LabelInstruction4";
            this.LabelInstruction4.Size = new System.Drawing.Size(271, 20);
            this.LabelInstruction4.TabIndex = 3;
            this.LabelInstruction4.Text = "> The game ends when you hit ";
            // 
            // LabelInstruction5
            // 
            this.LabelInstruction5.AutoSize = true;
            this.LabelInstruction5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.LabelInstruction5.Location = new System.Drawing.Point(15, 311);
            this.LabelInstruction5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelInstruction5.Name = "LabelInstruction5";
            this.LabelInstruction5.Size = new System.Drawing.Size(267, 20);
            this.LabelInstruction5.TabIndex = 4;
            this.LabelInstruction5.Text = "a pipe or you fall to the ground";
            // 
            // LabelInstruction3
            // 
            this.LabelInstruction3.AutoSize = true;
            this.LabelInstruction3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.LabelInstruction3.Location = new System.Drawing.Point(16, 226);
            this.LabelInstruction3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelInstruction3.Name = "LabelInstruction3";
            this.LabelInstruction3.Size = new System.Drawing.Size(139, 20);
            this.LabelInstruction3.TabIndex = 5;
            this.LabelInstruction3.Text = " you go through";
            // 
            // ButtonGoBack
            // 
            this.ButtonGoBack.BackColor = System.Drawing.Color.LimeGreen;
            this.ButtonGoBack.Cursor = System.Windows.Forms.Cursors.Default;
            this.ButtonGoBack.ForeColor = System.Drawing.Color.Black;
            this.ButtonGoBack.Location = new System.Drawing.Point(57, 395);
            this.ButtonGoBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonGoBack.Name = "ButtonGoBack";
            this.ButtonGoBack.Size = new System.Drawing.Size(184, 74);
            this.ButtonGoBack.TabIndex = 6;
            this.ButtonGoBack.Text = "Go Back";
            this.ButtonGoBack.UseVisualStyleBackColor = false;
            this.ButtonGoBack.Click += new System.EventHandler(this.GoBack_Click);
            // 
            // Controls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(331, 549);
            this.Controls.Add(this.ButtonGoBack);
            this.Controls.Add(this.LabelInstruction3);
            this.Controls.Add(this.LabelInstruction5);
            this.Controls.Add(this.LabelInstruction4);
            this.Controls.Add(this.LabelInstruction2);
            this.Controls.Add(this.LabelInstruction1);
            this.Controls.Add(this.LabelControls);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Controls";
            this.Text = "Controls";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void close()
        {
            this.Close();
        }

        #endregion

        private System.Windows.Forms.Label LabelControls;
        private System.Windows.Forms.Label LabelInstruction1;
        private System.Windows.Forms.Label LabelInstruction2;
        private System.Windows.Forms.Label LabelInstruction4;
        private System.Windows.Forms.Label LabelInstruction5;
        private System.Windows.Forms.Label LabelInstruction3;
        private System.Windows.Forms.Button ButtonGoBack;
    }
}