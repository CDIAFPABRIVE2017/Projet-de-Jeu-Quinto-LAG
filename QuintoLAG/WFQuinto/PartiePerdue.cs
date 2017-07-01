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
    public partial class PartiePerdue : Form
    {
        public PartiePerdue()
        {
            InitializeComponent();
        }

        private void textBoxRecord_TextChanged(object sender, EventArgs e)
        {
            if (textBoxRecord.Text != null&& textBoxRecord.Text.Length>=3)
            {
                button1OK.Visible = true;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ajouter enregistremetn score

            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
