﻿namespace WFQuinto
{
    partial class FrmScores
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
            this.textBox1top10 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1top10
            // 
            this.textBox1top10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1top10.Location = new System.Drawing.Point(28, 47);
            this.textBox1top10.Multiline = true;
            this.textBox1top10.Name = "textBox1top10";
            this.textBox1top10.Size = new System.Drawing.Size(388, 491);
            this.textBox1top10.TabIndex = 1;
            // 
            // FrmScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WFQuinto.Properties.Resources.zivLeiE;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(896, 586);
            this.Controls.Add(this.textBox1top10);
            this.Name = "FrmScores";
            this.Text = "Scores";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmScores_FormClosed);
            this.Shown += new System.EventHandler(this.FrmScores_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1top10;
    }
}