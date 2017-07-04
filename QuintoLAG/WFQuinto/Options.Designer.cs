namespace WFQuinto
{
    partial class Options
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCaractereMin = new System.Windows.Forms.TextBox();
            this.textBoxEssaisMax = new System.Windows.Forms.TextBox();
            this.textBoxPointErreur = new System.Windows.Forms.TextBox();
            this.textBoxpointSeconde = new System.Windows.Forms.TextBox();
            this.textBoxCharMax = new System.Windows.Forms.TextBox();
            this.label6CharMax = new System.Windows.Forms.Label();
            this.textBoxNbreManche = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre de Manches (2-5)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(464, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre de points/secondes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(464, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre  de caracteres  Min/Max";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(464, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nombre d\'essais Max";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(464, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nombre de points/erreurs";
            // 
            // textBoxCaractereMin
            // 
            this.textBoxCaractereMin.Location = new System.Drawing.Point(467, 286);
            this.textBoxCaractereMin.Name = "textBoxCaractereMin";
            this.textBoxCaractereMin.ReadOnly = true;
            this.textBoxCaractereMin.Size = new System.Drawing.Size(100, 20);
            this.textBoxCaractereMin.TabIndex = 7;
            // 
            // textBoxEssaisMax
            // 
            this.textBoxEssaisMax.Location = new System.Drawing.Point(467, 209);
            this.textBoxEssaisMax.Name = "textBoxEssaisMax";
            this.textBoxEssaisMax.ReadOnly = true;
            this.textBoxEssaisMax.Size = new System.Drawing.Size(100, 20);
            this.textBoxEssaisMax.TabIndex = 8;
            // 
            // textBoxPointErreur
            // 
            this.textBoxPointErreur.Location = new System.Drawing.Point(467, 124);
            this.textBoxPointErreur.Name = "textBoxPointErreur";
            this.textBoxPointErreur.ReadOnly = true;
            this.textBoxPointErreur.Size = new System.Drawing.Size(100, 20);
            this.textBoxPointErreur.TabIndex = 9;
            // 
            // textBoxpointSeconde
            // 
            this.textBoxpointSeconde.Location = new System.Drawing.Point(467, 46);
            this.textBoxpointSeconde.Name = "textBoxpointSeconde";
            this.textBoxpointSeconde.ReadOnly = true;
            this.textBoxpointSeconde.Size = new System.Drawing.Size(100, 20);
            this.textBoxpointSeconde.TabIndex = 10;
            // 
            // textBoxCharMax
            // 
            this.textBoxCharMax.Location = new System.Drawing.Point(467, 368);
            this.textBoxCharMax.Name = "textBoxCharMax";
            this.textBoxCharMax.ReadOnly = true;
            this.textBoxCharMax.Size = new System.Drawing.Size(100, 20);
            this.textBoxCharMax.TabIndex = 11;
            // 
            // label6CharMax
            // 
            this.label6CharMax.AutoSize = true;
            this.label6CharMax.Location = new System.Drawing.Point(464, 352);
            this.label6CharMax.Name = "label6CharMax";
            this.label6CharMax.Size = new System.Drawing.Size(138, 13);
            this.label6CharMax.TabIndex = 12;
            this.label6CharMax.Text = "Nombre  de caracteres Max";
            // 
            // textBoxNbreManche
            // 
            this.textBoxNbreManche.Location = new System.Drawing.Point(27, 105);
            this.textBoxNbreManche.Name = "textBoxNbreManche";
            this.textBoxNbreManche.ReadOnly = true;
            this.textBoxNbreManche.Size = new System.Drawing.Size(100, 20);
            this.textBoxNbreManche.TabIndex = 13;
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 498);
            this.Controls.Add(this.textBoxNbreManche);
            this.Controls.Add(this.label6CharMax);
            this.Controls.Add(this.textBoxCharMax);
            this.Controls.Add(this.textBoxpointSeconde);
            this.Controls.Add(this.textBoxPointErreur);
            this.Controls.Add(this.textBoxEssaisMax);
            this.Controls.Add(this.textBoxCaractereMin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Options";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Options_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCaractereMin;
        private System.Windows.Forms.TextBox textBoxEssaisMax;
        private System.Windows.Forms.TextBox textBoxPointErreur;
        private System.Windows.Forms.TextBox textBoxpointSeconde;
        private System.Windows.Forms.TextBox textBoxCharMax;
        private System.Windows.Forms.Label label6CharMax;
        private System.Windows.Forms.TextBox textBoxNbreManche;
    }
}