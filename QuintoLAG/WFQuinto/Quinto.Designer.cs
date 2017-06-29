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
            this.ClavierLigne2 = new System.Windows.Forms.FlowLayoutPanel();
            this.ClavierLigne1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ClavierLigne3 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelClavier = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panelClavier.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClavierLigne2
            // 
            this.ClavierLigne2.Location = new System.Drawing.Point(23, 69);
            this.ClavierLigne2.Name = "ClavierLigne2";
            this.ClavierLigne2.Size = new System.Drawing.Size(624, 60);
            this.ClavierLigne2.TabIndex = 3;
            // 
            // ClavierLigne1
            // 
            this.ClavierLigne1.Location = new System.Drawing.Point(3, 3);
            this.ClavierLigne1.Name = "ClavierLigne1";
            this.ClavierLigne1.Size = new System.Drawing.Size(624, 60);
            this.ClavierLigne1.TabIndex = 4;
            // 
            // ClavierLigne3
            // 
            this.ClavierLigne3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ClavierLigne3.Location = new System.Drawing.Point(52, 135);
            this.ClavierLigne3.Name = "ClavierLigne3";
            this.ClavierLigne3.Size = new System.Drawing.Size(439, 60);
            this.ClavierLigne3.TabIndex = 5;
            // 
            // panelClavier
            // 
            this.panelClavier.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panelClavier.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelClavier.Controls.Add(this.ClavierLigne3);
            this.panelClavier.Controls.Add(this.ClavierLigne2);
            this.panelClavier.Controls.Add(this.ClavierLigne1);
            this.panelClavier.Location = new System.Drawing.Point(232, 302);
            this.panelClavier.Name = "panelClavier";
            this.panelClavier.Size = new System.Drawing.Size(650, 205);
            this.panelClavier.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 208);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(341, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumBlue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
           
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Location = new System.Drawing.Point(51, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            // 
            // Quinto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 519);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panelClavier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.Name = "Quinto";
            this.Text = "Quinto";
            this.Load += new System.EventHandler(this.Quinto_Load);
            this.panelClavier.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel ClavierLigne2;
        private System.Windows.Forms.FlowLayoutPanel ClavierLigne1;
        private System.Windows.Forms.FlowLayoutPanel ClavierLigne3;
        private System.Windows.Forms.Panel panelClavier;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}

