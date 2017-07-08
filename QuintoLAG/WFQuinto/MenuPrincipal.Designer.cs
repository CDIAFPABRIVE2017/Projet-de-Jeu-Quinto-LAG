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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nouvellePartieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alimenterPiocheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouvellePartieToolStripMenuItem,
            this.alimenterPiocheToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.scoresToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // nouvellePartieToolStripMenuItem
            // 
            resources.ApplyResources(this.nouvellePartieToolStripMenuItem, "nouvellePartieToolStripMenuItem");
            this.nouvellePartieToolStripMenuItem.Name = "nouvellePartieToolStripMenuItem";
            this.nouvellePartieToolStripMenuItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // alimenterPiocheToolStripMenuItem
            // 
            resources.ApplyResources(this.alimenterPiocheToolStripMenuItem, "alimenterPiocheToolStripMenuItem");
            this.alimenterPiocheToolStripMenuItem.Name = "alimenterPiocheToolStripMenuItem";
            this.alimenterPiocheToolStripMenuItem.Click += new System.EventHandler(this.AlimenterPioche_Click);
            // 
            // optionsToolStripMenuItem
            // 
            resources.ApplyResources(this.optionsToolStripMenuItem, "optionsToolStripMenuItem");
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.button3_Click);
            // 
            // scoresToolStripMenuItem
            // 
            resources.ApplyResources(this.scoresToolStripMenuItem, "scoresToolStripMenuItem");
            this.scoresToolStripMenuItem.Name = "scoresToolStripMenuItem";
            this.scoresToolStripMenuItem.Click += new System.EventHandler(this.Scores_Click);
            // 
            // aideToolStripMenuItem
            // 
            resources.ApplyResources(this.aideToolStripMenuItem, "aideToolStripMenuItem");
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Click += new System.EventHandler(this.aideToolStripMenuItem_Click);
            // 
            // MenuPrincipal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nouvellePartieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alimenterPiocheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
    }
}