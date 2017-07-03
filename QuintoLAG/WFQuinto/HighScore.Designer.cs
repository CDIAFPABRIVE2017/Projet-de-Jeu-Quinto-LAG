namespace WFQuinto
{
    partial class HighScore
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
            this.textBox1Highscore = new System.Windows.Forms.TextBox();
            this.button1Enregistrer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1Highscore
            // 
            this.textBox1Highscore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1Highscore.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1Highscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1Highscore.ForeColor = System.Drawing.Color.Blue;
            this.textBox1Highscore.Location = new System.Drawing.Point(12, 465);
            this.textBox1Highscore.Name = "textBox1Highscore";
            this.textBox1Highscore.Size = new System.Drawing.Size(1250, 47);
            this.textBox1Highscore.TabIndex = 0;
            this.textBox1Highscore.Text = "Veuillez saisir ICI votre pseudo.";
            this.textBox1Highscore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1Highscore.Click += new System.EventHandler(this.textBox1Highscore_Click);
            this.textBox1Highscore.TextChanged += new System.EventHandler(this.textBox1Highscore_TextChanged);
            // 
            // button1Enregistrer
            // 
            this.button1Enregistrer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1Enregistrer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1Enregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Enregistrer.ForeColor = System.Drawing.Color.Red;
            this.button1Enregistrer.Location = new System.Drawing.Point(12, 527);
            this.button1Enregistrer.Name = "button1Enregistrer";
            this.button1Enregistrer.Size = new System.Drawing.Size(1250, 74);
            this.button1Enregistrer.TabIndex = 1;
            this.button1Enregistrer.Text = "Enregistrer votre score !";
            this.button1Enregistrer.UseVisualStyleBackColor = false;
            this.button1Enregistrer.Visible = false;
            this.button1Enregistrer.Click += new System.EventHandler(this.button1Enregistrer_Click);
            // 
            // HighScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WFQuinto.Properties.Resources.high_score_320x320;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1274, 613);
            this.Controls.Add(this.button1Enregistrer);
            this.Controls.Add(this.textBox1Highscore);
            this.MinimumSize = new System.Drawing.Size(1290, 652);
            this.Name = "HighScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HighScore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1Highscore;
        private System.Windows.Forms.Button button1Enregistrer;
    }
}