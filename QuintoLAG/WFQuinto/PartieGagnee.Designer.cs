namespace WFQuinto
{
    partial class PartieGagnee
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
            this.button1OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1OK
            // 
            this.button1OK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1OK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1OK.FlatAppearance.BorderSize = 5;
            this.button1OK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1OK.Font = new System.Drawing.Font("Magneto", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.button1OK.ForeColor = System.Drawing.Color.Navy;
            this.button1OK.Location = new System.Drawing.Point(12, 558);
            this.button1OK.Name = "button1OK";
            this.button1OK.Size = new System.Drawing.Size(926, 79);
            this.button1OK.TabIndex = 1;
            this.button1OK.Text = "Felicitations  Vous avez Gagné !";
            this.button1OK.UseVisualStyleBackColor = true;
            this.button1OK.Click += new System.EventHandler(this.button1OK_Click);
            // 
            // PartieGagnee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WFQuinto.Properties.Resources.golden_trophy;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(950, 649);
            this.Controls.Add(this.button1OK);
            this.MinimumSize = new System.Drawing.Size(966, 688);
            this.Name = "PartieGagnee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PartieGagnee";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1OK;
    }
}