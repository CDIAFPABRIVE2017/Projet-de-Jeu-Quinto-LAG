namespace WFQuinto
{
    partial class AlimenterPioche
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlimenterPioche));
            this.lBoxDictionnaire = new System.Windows.Forms.ListBox();
            this.lBoxPioche = new System.Windows.Forms.ListBox();
            this.butCharger = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.butSauvegarde = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.butToutAjouter = new System.Windows.Forms.Button();
            this.butViderListDictionnaire = new System.Windows.Forms.Button();
            this.butViderListePioche = new System.Windows.Forms.Button();
            this.butAjouter = new System.Windows.Forms.Button();
            this.butRetirer = new System.Windows.Forms.Button();
            this.tBoxMot = new System.Windows.Forms.TextBox();
            this.butMot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lBoxDictionnaire
            // 
            resources.ApplyResources(this.lBoxDictionnaire, "lBoxDictionnaire");
            this.lBoxDictionnaire.FormattingEnabled = true;
            this.lBoxDictionnaire.Name = "lBoxDictionnaire";
            this.lBoxDictionnaire.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lBoxDictionnaire.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lBoxPioche
            // 
            resources.ApplyResources(this.lBoxPioche, "lBoxPioche");
            this.lBoxPioche.FormattingEnabled = true;
            this.lBoxPioche.Name = "lBoxPioche";
            this.lBoxPioche.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            // 
            // butCharger
            // 
            resources.ApplyResources(this.butCharger, "butCharger");
            this.butCharger.Name = "butCharger";
            this.butCharger.UseVisualStyleBackColor = true;
            this.butCharger.Click += new System.EventHandler(this.butCharger_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            resources.ApplyResources(this.openFileDialog1, "openFileDialog1");
            // 
            // butSauvegarde
            // 
            resources.ApplyResources(this.butSauvegarde, "butSauvegarde");
            this.butSauvegarde.Name = "butSauvegarde";
            this.butSauvegarde.UseVisualStyleBackColor = true;
            this.butSauvegarde.Click += new System.EventHandler(this.butSauvegarde_Click);
            // 
            // saveFileDialog1
            // 
            resources.ApplyResources(this.saveFileDialog1, "saveFileDialog1");
            // 
            // butToutAjouter
            // 
            resources.ApplyResources(this.butToutAjouter, "butToutAjouter");
            this.butToutAjouter.Name = "butToutAjouter";
            this.butToutAjouter.UseVisualStyleBackColor = true;
            this.butToutAjouter.Click += new System.EventHandler(this.butToutAjouter_Click);
            // 
            // butViderListDictionnaire
            // 
            resources.ApplyResources(this.butViderListDictionnaire, "butViderListDictionnaire");
            this.butViderListDictionnaire.Name = "butViderListDictionnaire";
            this.butViderListDictionnaire.UseVisualStyleBackColor = true;
            this.butViderListDictionnaire.Click += new System.EventHandler(this.butViderListDictionnaire_Click);
            // 
            // butViderListePioche
            // 
            resources.ApplyResources(this.butViderListePioche, "butViderListePioche");
            this.butViderListePioche.Name = "butViderListePioche";
            this.butViderListePioche.UseVisualStyleBackColor = true;
            this.butViderListePioche.Click += new System.EventHandler(this.butViderListePioche_Click);
            // 
            // butAjouter
            // 
            resources.ApplyResources(this.butAjouter, "butAjouter");
            this.butAjouter.Name = "butAjouter";
            this.butAjouter.UseVisualStyleBackColor = true;
            this.butAjouter.Click += new System.EventHandler(this.butAjouterSelection_Click);
            // 
            // butRetirer
            // 
            resources.ApplyResources(this.butRetirer, "butRetirer");
            this.butRetirer.Name = "butRetirer";
            this.butRetirer.UseVisualStyleBackColor = true;
            this.butRetirer.Click += new System.EventHandler(this.butRetirer_Click);
            // 
            // tBoxMot
            // 
            resources.ApplyResources(this.tBoxMot, "tBoxMot");
            this.tBoxMot.Name = "tBoxMot";
            // 
            // butMot
            // 
            resources.ApplyResources(this.butMot, "butMot");
            this.butMot.Name = "butMot";
            this.butMot.UseVisualStyleBackColor = true;
            this.butMot.Click += new System.EventHandler(this.butMot_Click);
            // 
            // AlimenterPioche
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.butMot);
            this.Controls.Add(this.tBoxMot);
            this.Controls.Add(this.butRetirer);
            this.Controls.Add(this.butAjouter);
            this.Controls.Add(this.butViderListePioche);
            this.Controls.Add(this.butViderListDictionnaire);
            this.Controls.Add(this.butToutAjouter);
            this.Controls.Add(this.butSauvegarde);
            this.Controls.Add(this.butCharger);
            this.Controls.Add(this.lBoxPioche);
            this.Controls.Add(this.lBoxDictionnaire);
            this.Name = "AlimenterPioche";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AlimenterPioche_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lBoxDictionnaire;
        private System.Windows.Forms.ListBox lBoxPioche;
        private System.Windows.Forms.Button butCharger;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button butSauvegarde;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button butToutAjouter;
        private System.Windows.Forms.Button butViderListDictionnaire;
        private System.Windows.Forms.Button butViderListePioche;
        private System.Windows.Forms.Button butAjouter;
        private System.Windows.Forms.Button butRetirer;
        private System.Windows.Forms.TextBox tBoxMot;
        private System.Windows.Forms.Button butMot;
    }
}