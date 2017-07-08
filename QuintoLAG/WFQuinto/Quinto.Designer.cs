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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quinto));
            this.ClavierLigne2 = new System.Windows.Forms.FlowLayoutPanel();
            this.ClavierLigne1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ClavierLigne3 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelClavier = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelTempsReel = new System.Windows.Forms.Label();
            this.toucheUtilisées = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxErreur = new System.Windows.Forms.GroupBox();
            this.label2nbreErreur = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mancheNombreManche = new System.Windows.Forms.Label();
            this.labelMotaDeviner = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.label2ScoreTotal = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelClavier.SuspendLayout();
            this.groupBoxErreur.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ClavierLigne2
            // 
            resources.ApplyResources(this.ClavierLigne2, "ClavierLigne2");
            this.ClavierLigne2.Name = "ClavierLigne2";
            // 
            // ClavierLigne1
            // 
            resources.ApplyResources(this.ClavierLigne1, "ClavierLigne1");
            this.ClavierLigne1.BackColor = System.Drawing.Color.Transparent;
            this.ClavierLigne1.Name = "ClavierLigne1";
            // 
            // ClavierLigne3
            // 
            resources.ApplyResources(this.ClavierLigne3, "ClavierLigne3");
            this.ClavierLigne3.Name = "ClavierLigne3";
            // 
            // panelClavier
            // 
            resources.ApplyResources(this.panelClavier, "panelClavier");
            this.panelClavier.BackColor = System.Drawing.Color.Transparent;
            this.panelClavier.Controls.Add(this.ClavierLigne3);
            this.panelClavier.Controls.Add(this.ClavierLigne2);
            this.panelClavier.Controls.Add(this.ClavierLigne1);
            this.panelClavier.Name = "panelClavier";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Name = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelTempsReel
            // 
            resources.ApplyResources(this.labelTempsReel, "labelTempsReel");
            this.labelTempsReel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTempsReel.Cursor = System.Windows.Forms.Cursors.No;
            this.labelTempsReel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTempsReel.ForeColor = System.Drawing.Color.Crimson;
            this.labelTempsReel.Name = "labelTempsReel";
            // 
            // toucheUtilisées
            // 
            resources.ApplyResources(this.toucheUtilisées, "toucheUtilisées");
            this.toucheUtilisées.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.toucheUtilisées.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.toucheUtilisées.Cursor = System.Windows.Forms.Cursors.No;
            this.toucheUtilisées.Name = "toucheUtilisées";
            // 
            // groupBoxErreur
            // 
            resources.ApplyResources(this.groupBoxErreur, "groupBoxErreur");
            this.groupBoxErreur.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBoxErreur.Controls.Add(this.label2nbreErreur);
            this.groupBoxErreur.Cursor = System.Windows.Forms.Cursors.No;
            this.groupBoxErreur.Name = "groupBoxErreur";
            this.groupBoxErreur.TabStop = false;
            // 
            // label2nbreErreur
            // 
            resources.ApplyResources(this.label2nbreErreur, "label2nbreErreur");
            this.label2nbreErreur.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2nbreErreur.ForeColor = System.Drawing.Color.Red;
            this.label2nbreErreur.Name = "label2nbreErreur";
            this.label2nbreErreur.TextChanged += new System.EventHandler(this.label2nbreErreur_TextChanged);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.mancheNombreManche);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // mancheNombreManche
            // 
            resources.ApplyResources(this.mancheNombreManche, "mancheNombreManche");
            this.mancheNombreManche.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.mancheNombreManche.ForeColor = System.Drawing.Color.DodgerBlue;
            this.mancheNombreManche.Name = "mancheNombreManche";
            // 
            // labelMotaDeviner
            // 
            resources.ApplyResources(this.labelMotaDeviner, "labelMotaDeviner");
            this.labelMotaDeviner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelMotaDeviner.CausesValidation = false;
            this.labelMotaDeviner.Cursor = System.Windows.Forms.Cursors.Cross;
            this.labelMotaDeviner.ForeColor = System.Drawing.Color.Black;
            this.labelMotaDeviner.Name = "labelMotaDeviner";
            // 
            // labelScore
            // 
            resources.ApplyResources(this.labelScore, "labelScore");
            this.labelScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelScore.Name = "labelScore";
            // 
            // label2ScoreTotal
            // 
            resources.ApplyResources(this.label2ScoreTotal, "label2ScoreTotal");
            this.label2ScoreTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2ScoreTotal.Name = "label2ScoreTotal";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBox1.Image = global::WFQuinto.Properties.Resources.potence;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // Quinto
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2ScoreTotal);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelMotaDeviner);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxErreur);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toucheUtilisées);
            this.Controls.Add(this.labelTempsReel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelClavier);
            this.ForeColor = System.Drawing.Color.Crimson;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "Quinto";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Quinto_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Quinto_KeyPress);
            this.panelClavier.ResumeLayout(false);
            this.groupBoxErreur.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel ClavierLigne2;
        private System.Windows.Forms.FlowLayoutPanel ClavierLigne1;
        private System.Windows.Forms.FlowLayoutPanel ClavierLigne3;
        private System.Windows.Forms.Panel panelClavier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelTempsReel;
        private System.Windows.Forms.FlowLayoutPanel toucheUtilisées;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBoxErreur;
        private System.Windows.Forms.Label label2nbreErreur;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label mancheNombreManche;
        private System.Windows.Forms.Label labelMotaDeviner;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label label2ScoreTotal;
    }
}

