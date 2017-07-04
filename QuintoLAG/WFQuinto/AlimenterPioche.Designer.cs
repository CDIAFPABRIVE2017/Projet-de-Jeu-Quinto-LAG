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
            this.lBoxDictionnaire.FormattingEnabled = true;
            this.lBoxDictionnaire.Location = new System.Drawing.Point(12, 16);
            this.lBoxDictionnaire.Name = "lBoxDictionnaire";
            this.lBoxDictionnaire.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lBoxDictionnaire.Size = new System.Drawing.Size(140, 368);
            this.lBoxDictionnaire.TabIndex = 0;
            this.lBoxDictionnaire.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lBoxPioche
            // 
            this.lBoxPioche.FormattingEnabled = true;
            this.lBoxPioche.Location = new System.Drawing.Point(332, 16);
            this.lBoxPioche.Name = "lBoxPioche";
            this.lBoxPioche.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lBoxPioche.Size = new System.Drawing.Size(140, 368);
            this.lBoxPioche.TabIndex = 1;
            // 
            // butCharger
            // 
            this.butCharger.Location = new System.Drawing.Point(12, 397);
            this.butCharger.Name = "butCharger";
            this.butCharger.Size = new System.Drawing.Size(140, 23);
            this.butCharger.TabIndex = 2;
            this.butCharger.Text = "Charger";
            this.butCharger.UseVisualStyleBackColor = true;
            this.butCharger.Click += new System.EventHandler(this.butCharger_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // butSauvegarde
            // 
            this.butSauvegarde.Location = new System.Drawing.Point(332, 397);
            this.butSauvegarde.Name = "butSauvegarde";
            this.butSauvegarde.Size = new System.Drawing.Size(140, 23);
            this.butSauvegarde.TabIndex = 3;
            this.butSauvegarde.Text = "Sauvegarder";
            this.butSauvegarde.UseVisualStyleBackColor = true;
            this.butSauvegarde.Click += new System.EventHandler(this.butSauvegarde_Click);
            // 
            // butToutAjouter
            // 
            this.butToutAjouter.Location = new System.Drawing.Point(195, 182);
            this.butToutAjouter.Name = "butToutAjouter";
            this.butToutAjouter.Size = new System.Drawing.Size(94, 23);
            this.butToutAjouter.TabIndex = 4;
            this.butToutAjouter.Text = "Tout ajouter";
            this.butToutAjouter.UseVisualStyleBackColor = true;
            this.butToutAjouter.Click += new System.EventHandler(this.butToutAjouter_Click);
            // 
            // butViderListDictionnaire
            // 
            this.butViderListDictionnaire.Location = new System.Drawing.Point(12, 426);
            this.butViderListDictionnaire.Name = "butViderListDictionnaire";
            this.butViderListDictionnaire.Size = new System.Drawing.Size(140, 23);
            this.butViderListDictionnaire.TabIndex = 5;
            this.butViderListDictionnaire.Text = "Vider liste";
            this.butViderListDictionnaire.UseVisualStyleBackColor = true;
            this.butViderListDictionnaire.Click += new System.EventHandler(this.butViderListDictionnaire_Click);
            // 
            // butViderListePioche
            // 
            this.butViderListePioche.Location = new System.Drawing.Point(332, 426);
            this.butViderListePioche.Name = "butViderListePioche";
            this.butViderListePioche.Size = new System.Drawing.Size(140, 23);
            this.butViderListePioche.TabIndex = 6;
            this.butViderListePioche.Text = "Vider liste";
            this.butViderListePioche.UseVisualStyleBackColor = true;
            this.butViderListePioche.Click += new System.EventHandler(this.butViderListePioche_Click);
            // 
            // butAjouter
            // 
            this.butAjouter.Location = new System.Drawing.Point(195, 211);
            this.butAjouter.Name = "butAjouter";
            this.butAjouter.Size = new System.Drawing.Size(94, 23);
            this.butAjouter.TabIndex = 7;
            this.butAjouter.Text = "Ajouter >>>>";
            this.butAjouter.UseVisualStyleBackColor = true;
            this.butAjouter.Click += new System.EventHandler(this.butAjouterSelection_Click);
            // 
            // butRetirer
            // 
            this.butRetirer.Location = new System.Drawing.Point(195, 240);
            this.butRetirer.Name = "butRetirer";
            this.butRetirer.Size = new System.Drawing.Size(94, 23);
            this.butRetirer.TabIndex = 8;
            this.butRetirer.Text = "<<<< Retirer";
            this.butRetirer.UseVisualStyleBackColor = true;
            this.butRetirer.Click += new System.EventHandler(this.butRetirer_Click);
            // 
            // tBoxMot
            // 
            this.tBoxMot.Location = new System.Drawing.Point(158, 42);
            this.tBoxMot.Name = "tBoxMot";
            this.tBoxMot.Size = new System.Drawing.Size(168, 20);
            this.tBoxMot.TabIndex = 9;
            // 
            // butMot
            // 
            this.butMot.Location = new System.Drawing.Point(195, 68);
            this.butMot.Name = "butMot";
            this.butMot.Size = new System.Drawing.Size(94, 23);
            this.butMot.TabIndex = 10;
            this.butMot.Text = "Ajouter mot";
            this.butMot.UseVisualStyleBackColor = true;
            this.butMot.Click += new System.EventHandler(this.butMot_Click);
            // 
            // AlimenterPioche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
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
            this.Text = "AlimenterPioche";
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