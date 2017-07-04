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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mancheNombreManche = new System.Windows.Forms.Label();
            this.labelMotaDeviner = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.label2ScoreTotal = new System.Windows.Forms.Label();
            this.panelClavier.SuspendLayout();
            this.groupBoxErreur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClavierLigne2
            // 
            this.ClavierLigne2.Location = new System.Drawing.Point(27, 69);
            this.ClavierLigne2.Name = "ClavierLigne2";
            this.ClavierLigne2.Size = new System.Drawing.Size(737, 60);
            this.ClavierLigne2.TabIndex = 3;
            this.ClavierLigne2.WrapContents = false;
            // 
            // ClavierLigne1
            // 
            this.ClavierLigne1.BackColor = System.Drawing.Color.Transparent;
            this.ClavierLigne1.Location = new System.Drawing.Point(3, 3);
            this.ClavierLigne1.Name = "ClavierLigne1";
            this.ClavierLigne1.Size = new System.Drawing.Size(737, 60);
            this.ClavierLigne1.TabIndex = 4;
            this.ClavierLigne1.WrapContents = false;
            // 
            // ClavierLigne3
            // 
            this.ClavierLigne3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ClavierLigne3.Location = new System.Drawing.Point(50, 135);
            this.ClavierLigne3.Name = "ClavierLigne3";
            this.ClavierLigne3.Size = new System.Drawing.Size(521, 60);
            this.ClavierLigne3.TabIndex = 5;
            this.ClavierLigne3.WrapContents = false;
            // 
            // panelClavier
            // 
            this.panelClavier.BackColor = System.Drawing.Color.Transparent;
            this.panelClavier.Controls.Add(this.ClavierLigne3);
            this.panelClavier.Controls.Add(this.ClavierLigne2);
            this.panelClavier.Controls.Add(this.ClavierLigne1);
            this.panelClavier.Location = new System.Drawing.Point(5, 343);
            this.panelClavier.Name = "panelClavier";
            this.panelClavier.Size = new System.Drawing.Size(770, 202);
            this.panelClavier.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Temps écoulé";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelTempsReel
            // 
            this.labelTempsReel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTempsReel.Cursor = System.Windows.Forms.Cursors.No;
            this.labelTempsReel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTempsReel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTempsReel.ForeColor = System.Drawing.Color.Crimson;
            this.labelTempsReel.Location = new System.Drawing.Point(107, 8);
            this.labelTempsReel.Name = "labelTempsReel";
            this.labelTempsReel.Size = new System.Drawing.Size(94, 16);
            this.labelTempsReel.TabIndex = 11;
            // 
            // toucheUtilisées
            // 
            this.toucheUtilisées.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.toucheUtilisées.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.toucheUtilisées.Cursor = System.Windows.Forms.Cursors.No;
            this.toucheUtilisées.Location = new System.Drawing.Point(453, 133);
            this.toucheUtilisées.Name = "toucheUtilisées";
            this.toucheUtilisées.Size = new System.Drawing.Size(452, 147);
            this.toucheUtilisées.TabIndex = 15;
            // 
            // groupBoxErreur
            // 
            this.groupBoxErreur.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBoxErreur.Controls.Add(this.label2nbreErreur);
            this.groupBoxErreur.Cursor = System.Windows.Forms.Cursors.No;
            this.groupBoxErreur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxErreur.Location = new System.Drawing.Point(700, 12);
            this.groupBoxErreur.Name = "groupBoxErreur";
            this.groupBoxErreur.Size = new System.Drawing.Size(205, 115);
            this.groupBoxErreur.TabIndex = 26;
            this.groupBoxErreur.TabStop = false;
            this.groupBoxErreur.Text = "Nombre d\'erreurs";
            // 
            // label2nbreErreur
            // 
            this.label2nbreErreur.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2nbreErreur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2nbreErreur.Font = new System.Drawing.Font("Brush Script MT", 70F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2nbreErreur.ForeColor = System.Drawing.Color.Red;
            this.label2nbreErreur.Location = new System.Drawing.Point(3, 16);
            this.label2nbreErreur.Name = "label2nbreErreur";
            this.label2nbreErreur.Size = new System.Drawing.Size(199, 96);
            this.label2nbreErreur.TabIndex = 0;
            this.label2nbreErreur.Text = "X";
            this.label2nbreErreur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2nbreErreur.TextChanged += new System.EventHandler(this.label2nbreErreur_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBox1.Image = global::WFQuinto.Properties.Resources.potence;
            this.pictureBox1.Location = new System.Drawing.Point(5, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(435, 252);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.mancheNombreManche);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(453, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 115);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manche  / Nombre de Manches";
            // 
            // mancheNombreManche
            // 
            this.mancheNombreManche.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.mancheNombreManche.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mancheNombreManche.Font = new System.Drawing.Font("Brush Script MT", 50F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mancheNombreManche.ForeColor = System.Drawing.Color.DodgerBlue;
            this.mancheNombreManche.Location = new System.Drawing.Point(3, 16);
            this.mancheNombreManche.Name = "mancheNombreManche";
            this.mancheNombreManche.Size = new System.Drawing.Size(234, 96);
            this.mancheNombreManche.TabIndex = 0;
            this.mancheNombreManche.Text = "x/X";
            this.mancheNombreManche.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMotaDeviner
            // 
            this.labelMotaDeviner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelMotaDeviner.CausesValidation = false;
            this.labelMotaDeviner.Cursor = System.Windows.Forms.Cursors.Cross;
            this.labelMotaDeviner.Font = new System.Drawing.Font("Lucida Handwriting", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMotaDeviner.ForeColor = System.Drawing.Color.Black;
            this.labelMotaDeviner.Location = new System.Drawing.Point(5, 283);
            this.labelMotaDeviner.Name = "labelMotaDeviner";
            this.labelMotaDeviner.Size = new System.Drawing.Size(901, 57);
            this.labelMotaDeviner.TabIndex = 32;
            this.labelMotaDeviner.Text = "mot à Deviner (5 à 25 lettres max.)";
            this.labelMotaDeviner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelScore
            // 
            this.labelScore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelScore.Location = new System.Drawing.Point(282, 7);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(54, 14);
            this.labelScore.TabIndex = 33;
            this.labelScore.Text = "Score";
            this.labelScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2ScoreTotal
            // 
            this.label2ScoreTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2ScoreTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2ScoreTotal.Location = new System.Drawing.Point(342, 7);
            this.label2ScoreTotal.Name = "label2ScoreTotal";
            this.label2ScoreTotal.Size = new System.Drawing.Size(43, 15);
            this.label2ScoreTotal.TabIndex = 34;
            this.label2ScoreTotal.Text = "0";
            this.label2ScoreTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Quinto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 557);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Crimson;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(942, 600);
            this.Name = "Quinto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quinto";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Quinto_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Quinto_KeyPress);
            this.panelClavier.ResumeLayout(false);
            this.groupBoxErreur.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
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

