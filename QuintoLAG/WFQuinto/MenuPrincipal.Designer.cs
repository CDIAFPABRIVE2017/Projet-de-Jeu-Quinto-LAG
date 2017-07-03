namespace WFQuinto
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.NouvellePartie = new System.Windows.Forms.Button();
            this.AlimenterPioche = new System.Windows.Forms.Button();
            this.Options = new System.Windows.Forms.Button();
            this.Scores = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelRegles = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NouvellePartie
            // 
            this.NouvellePartie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NouvellePartie.Location = new System.Drawing.Point(6, 601);
            this.NouvellePartie.Name = "NouvellePartie";
            this.NouvellePartie.Size = new System.Drawing.Size(302, 51);
            this.NouvellePartie.TabIndex = 0;
            this.NouvellePartie.Text = "Nouvelle Partie";
            this.NouvellePartie.UseVisualStyleBackColor = true;
            this.NouvellePartie.Click += new System.EventHandler(this.button1_Click);
            // 
            // AlimenterPioche
            // 
            this.AlimenterPioche.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AlimenterPioche.Location = new System.Drawing.Point(784, 601);
            this.AlimenterPioche.Name = "AlimenterPioche";
            this.AlimenterPioche.Size = new System.Drawing.Size(302, 51);
            this.AlimenterPioche.TabIndex = 1;
            this.AlimenterPioche.Text = "Alimenter Pioche";
            this.AlimenterPioche.UseVisualStyleBackColor = true;
            this.AlimenterPioche.Click += new System.EventHandler(this.AlimenterPioche_Click);
            // 
            // Options
            // 
            this.Options.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Options.Location = new System.Drawing.Point(467, 601);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(302, 51);
            this.Options.TabIndex = 2;
            this.Options.Text = "Options";
            this.Options.UseVisualStyleBackColor = true;
            this.Options.Click += new System.EventHandler(this.button3_Click);
            // 
            // Scores
            // 
            this.Scores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Scores.Location = new System.Drawing.Point(784, 544);
            this.Scores.Name = "Scores";
            this.Scores.Size = new System.Drawing.Size(302, 51);
            this.Scores.TabIndex = 3;
            this.Scores.Text = "Scores";
            this.Scores.UseVisualStyleBackColor = true;
            this.Scores.Click += new System.EventHandler(this.Scores_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::WFQuinto.Properties.Resources.téléchargement;
            this.pictureBox1.Location = new System.Drawing.Point(6, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 432);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // labelRegles
            // 
            this.labelRegles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelRegles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelRegles.Location = new System.Drawing.Point(312, 5);
            this.labelRegles.Name = "labelRegles";
            this.labelRegles.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelRegles.Size = new System.Drawing.Size(302, 432);
            this.labelRegles.TabIndex = 6;
            this.labelRegles.Text = resources.GetString("labelRegles.Text");
            this.labelRegles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelRegles.Visible = false;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1098, 664);
            this.Controls.Add(this.labelRegles);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Scores);
            this.Controls.Add(this.Options);
            this.Controls.Add(this.AlimenterPioche);
            this.Controls.Add(this.NouvellePartie);
            this.IsMdiContainer = true;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

            }

            #endregion

            private System.Windows.Forms.Button NouvellePartie;
            private System.Windows.Forms.Button AlimenterPioche;
            private System.Windows.Forms.Button Options;
            private System.Windows.Forms.Button Scores;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelRegles;
    }
}