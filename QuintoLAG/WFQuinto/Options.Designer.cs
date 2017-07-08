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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
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
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // textBoxCaractereMin
            // 
            resources.ApplyResources(this.textBoxCaractereMin, "textBoxCaractereMin");
            this.textBoxCaractereMin.Name = "textBoxCaractereMin";
            this.textBoxCaractereMin.ReadOnly = true;
            // 
            // textBoxEssaisMax
            // 
            resources.ApplyResources(this.textBoxEssaisMax, "textBoxEssaisMax");
            this.textBoxEssaisMax.Name = "textBoxEssaisMax";
            this.textBoxEssaisMax.ReadOnly = true;
            // 
            // textBoxPointErreur
            // 
            resources.ApplyResources(this.textBoxPointErreur, "textBoxPointErreur");
            this.textBoxPointErreur.Name = "textBoxPointErreur";
            this.textBoxPointErreur.ReadOnly = true;
            // 
            // textBoxpointSeconde
            // 
            resources.ApplyResources(this.textBoxpointSeconde, "textBoxpointSeconde");
            this.textBoxpointSeconde.Name = "textBoxpointSeconde";
            this.textBoxpointSeconde.ReadOnly = true;
            // 
            // textBoxCharMax
            // 
            resources.ApplyResources(this.textBoxCharMax, "textBoxCharMax");
            this.textBoxCharMax.Name = "textBoxCharMax";
            this.textBoxCharMax.ReadOnly = true;
            // 
            // label6CharMax
            // 
            resources.ApplyResources(this.label6CharMax, "label6CharMax");
            this.label6CharMax.Name = "label6CharMax";
            // 
            // textBoxNbreManche
            // 
            resources.ApplyResources(this.textBoxNbreManche, "textBoxNbreManche");
            this.textBoxNbreManche.Name = "textBoxNbreManche";
            this.textBoxNbreManche.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNbreManche_Validating);
            // 
            // Options
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Options_FormClosed);
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