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
            this.startChrono = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.stopChrono = new System.Windows.Forms.Button();
            this.labelTempsReel = new System.Windows.Forms.Label();
            this.labelTempsFinal = new System.Windows.Forms.Label();
            this.toucheUtilisées = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.panelClavier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // ClavierLigne2
            // 
            this.ClavierLigne2.Location = new System.Drawing.Point(23, 69);
            this.ClavierLigne2.Name = "ClavierLigne2";
            this.ClavierLigne2.Size = new System.Drawing.Size(624, 60);
            this.ClavierLigne2.TabIndex = 3;
            this.ClavierLigne2.WrapContents = false;
            // 
            // ClavierLigne1
            // 
            this.ClavierLigne1.Location = new System.Drawing.Point(3, 3);
            this.ClavierLigne1.Name = "ClavierLigne1";
            this.ClavierLigne1.Size = new System.Drawing.Size(624, 60);
            this.ClavierLigne1.TabIndex = 4;
            this.ClavierLigne1.WrapContents = false;
            // 
            // ClavierLigne3
            // 
            this.ClavierLigne3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ClavierLigne3.Location = new System.Drawing.Point(52, 132);
            this.ClavierLigne3.Name = "ClavierLigne3";
            this.ClavierLigne3.Size = new System.Drawing.Size(439, 60);
            this.ClavierLigne3.TabIndex = 5;
            this.ClavierLigne3.WrapContents = false;
            // 
            // panelClavier
            // 
            this.panelClavier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelClavier.BackColor = System.Drawing.Color.Transparent;
            this.panelClavier.Controls.Add(this.ClavierLigne3);
            this.panelClavier.Controls.Add(this.ClavierLigne2);
            this.panelClavier.Controls.Add(this.ClavierLigne1);
            this.panelClavier.Location = new System.Drawing.Point(1, 299);
            this.panelClavier.Name = "panelClavier";
            this.panelClavier.Size = new System.Drawing.Size(650, 202);
            this.panelClavier.TabIndex = 0;
            // 
            // startChrono
            // 
            this.startChrono.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startChrono.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.startChrono.FlatAppearance.BorderSize = 2;
            this.startChrono.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumBlue;
            this.startChrono.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.startChrono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startChrono.Location = new System.Drawing.Point(428, 52);
            this.startChrono.Name = "startChrono";
            this.startChrono.Size = new System.Drawing.Size(75, 42);
            this.startChrono.TabIndex = 3;
            this.startChrono.Text = "START";
            this.startChrono.UseVisualStyleBackColor = true;
            this.startChrono.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Temps écoulé";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(425, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Erreur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Manche";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Temps Total";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // stopChrono
            // 
            this.stopChrono.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stopChrono.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.stopChrono.FlatAppearance.BorderSize = 2;
            this.stopChrono.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumBlue;
            this.stopChrono.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.stopChrono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopChrono.Location = new System.Drawing.Point(428, 122);
            this.stopChrono.Name = "stopChrono";
            this.stopChrono.Size = new System.Drawing.Size(75, 42);
            this.stopChrono.TabIndex = 10;
            this.stopChrono.Text = "STOP";
            this.stopChrono.UseVisualStyleBackColor = true;
            this.stopChrono.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelTempsReel
            // 
            this.labelTempsReel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTempsReel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTempsReel.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.labelTempsReel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTempsReel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTempsReel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelTempsReel.Location = new System.Drawing.Point(105, 9);
            this.labelTempsReel.Name = "labelTempsReel";
            this.labelTempsReel.Size = new System.Drawing.Size(77, 13);
            this.labelTempsReel.TabIndex = 11;
            // 
            // labelTempsFinal
            // 
            this.labelTempsFinal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTempsFinal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTempsFinal.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.labelTempsFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTempsFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTempsFinal.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelTempsFinal.Location = new System.Drawing.Point(311, 9);
            this.labelTempsFinal.Name = "labelTempsFinal";
            this.labelTempsFinal.Size = new System.Drawing.Size(95, 15);
            this.labelTempsFinal.TabIndex = 13;
            // 
            // toucheUtilisées
            // 
            this.toucheUtilisées.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toucheUtilisées.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.toucheUtilisées.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.toucheUtilisées.Cursor = System.Windows.Forms.Cursors.No;
            this.toucheUtilisées.Location = new System.Drawing.Point(12, 32);
            this.toucheUtilisées.Name = "toucheUtilisées";
            this.toucheUtilisées.Size = new System.Drawing.Size(394, 261);
            this.toucheUtilisées.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(657, 481);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(291, 20);
            this.textBox1.TabIndex = 19;
            this.textBox1.Text = "Mot a Deviner";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(412, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Test ecriture clavier";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WFQuinto.Properties.Resources._9;
            this.pictureBox1.Location = new System.Drawing.Point(535, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(535, 221);
            this.progressBar1.MarqueeAnimationSpeed = 0;
            this.progressBar1.Maximum = 9;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(180, 38);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 23;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(731, 65);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 24;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Quinto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 513);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.toucheUtilisées);
            this.Controls.Add(this.labelTempsFinal);
            this.Controls.Add(this.labelTempsReel);
            this.Controls.Add(this.stopChrono);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startChrono);
            this.Controls.Add(this.panelClavier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(1102, 43);
            this.Name = "Quinto";
            this.Text = "Quinto";
            this.Load += new System.EventHandler(this.Quinto_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Quinto_KeyPress);
            this.panelClavier.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel ClavierLigne2;
        private System.Windows.Forms.FlowLayoutPanel ClavierLigne1;
        private System.Windows.Forms.FlowLayoutPanel ClavierLigne3;
        private System.Windows.Forms.Panel panelClavier;
        private System.Windows.Forms.Button startChrono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button stopChrono;
        private System.Windows.Forms.Label labelTempsReel;
        private System.Windows.Forms.Label labelTempsFinal;
        private System.Windows.Forms.FlowLayoutPanel toucheUtilisées;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

