namespace WFQuinto
{
    partial class PartiePerdue
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
            this.textBoxRecord = new System.Windows.Forms.TextBox();
            this.button1OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxRecord
            // 
            this.textBoxRecord.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRecord.ForeColor = System.Drawing.Color.Red;
            this.textBoxRecord.Location = new System.Drawing.Point(239, 463);
            this.textBoxRecord.Name = "textBoxRecord";
            this.textBoxRecord.Size = new System.Drawing.Size(484, 49);
            this.textBoxRecord.TabIndex = 0;
            this.textBoxRecord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxRecord.TextChanged += new System.EventHandler(this.textBoxRecord_TextChanged);
            // 
            // button1OK
            // 
            this.button1OK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1OK.AutoSize = true;
            this.button1OK.BackColor = System.Drawing.Color.LawnGreen;
            this.button1OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1OK.Location = new System.Drawing.Point(12, 392);
            this.button1OK.Name = "button1OK";
            this.button1OK.Size = new System.Drawing.Size(945, 36);
            this.button1OK.TabIndex = 1;
            this.button1OK.Text = "Enregistrement du Score";
            this.button1OK.UseVisualStyleBackColor = false;
            this.button1OK.Visible = false;
            this.button1OK.Click += new System.EventHandler(this.button1_Click);
            // 
            // PartiePerdue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WFQuinto.Properties.Resources.gameoverX;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(969, 546);
            this.Controls.Add(this.button1OK);
            this.Controls.Add(this.textBoxRecord);
            this.Name = "PartiePerdue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PartiePerdue";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxRecord;
        private System.Windows.Forms.Button button1OK;
    }
}