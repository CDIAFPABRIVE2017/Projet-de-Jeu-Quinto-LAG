namespace WFQuinto
{
    partial class highScoreInput
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(highScoreInput));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnValider = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.errorProvider1.SetError(this.label1, resources.GetString("label1.Error"));
            this.errorProvider1.SetIconAlignment(this.label1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label1, ((int)(resources.GetObject("label1.IconPadding"))));
            this.label1.Name = "label1";
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.errorProvider1.SetError(this.textBox1, resources.GetString("textBox1.Error"));
            this.errorProvider1.SetIconAlignment(this.textBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("textBox1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.textBox1, ((int)(resources.GetObject("textBox1.IconPadding"))));
            this.textBox1.Name = "textBox1";
            this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            resources.ApplyResources(this.errorProvider1, "errorProvider1");
            // 
            // btnValider
            // 
            resources.ApplyResources(this.btnValider, "btnValider");
            this.errorProvider1.SetError(this.btnValider, resources.GetString("btnValider.Error"));
            this.errorProvider1.SetIconAlignment(this.btnValider, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnValider.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.btnValider, ((int)(resources.GetObject("btnValider.IconPadding"))));
            this.btnValider.Name = "btnValider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // highScoreInput
            // 
            this.AcceptButton = this.btnValider;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "highScoreInput";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnValider;
    }
}