namespace WFQuinto
{
    partial class Quinto
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelClavier = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PanelClavier
            // 
            this.PanelClavier.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.PanelClavier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelClavier.Location = new System.Drawing.Point(291, 331);
            this.PanelClavier.Name = "PanelClavier";
            this.PanelClavier.Size = new System.Drawing.Size(569, 176);
            this.PanelClavier.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(431, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 20);
            this.textBox1.TabIndex = 1;
            // 
            // Quinto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 519);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PanelClavier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.Name = "Quinto";
            this.Text = "Quinto";
            this.Load += new System.EventHandler(this.Quinto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel PanelClavier;
        private System.Windows.Forms.TextBox textBox1;
    }
}

