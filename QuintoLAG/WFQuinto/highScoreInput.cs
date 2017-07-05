using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFQuinto
{
    public partial class highScoreInput : Form
    {
        public string pseudo
        {
            get
            {
                return textBox1.Text;
            }
        }

        public highScoreInput()
        {
            InitializeComponent();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            this.errorProvider1.SetError(textBox1, string.Empty);
            if (textBox1.Text.Length > 10)
            {
                e.Cancel = true;
                this.errorProvider1.SetError(textBox1, "le nom doit être d inferieur à 10 caracteres.");
            }
            if (textBox1.Text.Contains("lexis"))
            {
                e.Cancel = true;
                this.errorProvider1.SetError(textBox1, "Ce nom n'est pas autorisé");
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
