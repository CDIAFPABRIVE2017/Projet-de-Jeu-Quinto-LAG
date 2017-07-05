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
    public partial class PartieGagnee : Form
    {
        public PartieGagnee()
        {
            InitializeComponent();
        }
        /// <summary>
        /// partie gagné sans meilleur score
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1OK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
