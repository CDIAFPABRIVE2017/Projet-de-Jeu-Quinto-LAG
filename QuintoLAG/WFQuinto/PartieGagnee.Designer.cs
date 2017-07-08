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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartieGagnee));
            this.button1OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1OK
            // 
            resources.ApplyResources(this.button1OK, "button1OK");
            this.button1OK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1OK.FlatAppearance.BorderSize = 5;
            this.button1OK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1OK.ForeColor = System.Drawing.Color.Navy;
            this.button1OK.Name = "button1OK";
            this.button1OK.UseVisualStyleBackColor = true;
            this.button1OK.Click += new System.EventHandler(this.button1OK_Click);
            // 
            // PartieGagnee
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WFQuinto.Properties.Resources.golden_trophy;
            this.Controls.Add(this.button1OK);
            this.Name = "PartieGagnee";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1OK;
    }
}