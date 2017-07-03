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
    public partial class HighScore : Form
    {
        public HighScore()
        {
            InitializeComponent();
        }


        /// <summary>
        /// R.A.Z  textbox on click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1Highscore_Click(object sender, EventArgs e)
        {
            textBox1Highscore.Text = null;
        }


        /// <summary>
        /// recuperer nom pour enregistrer score
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1Highscore_TextChanged(object sender, EventArgs e)
        {
            if (textBox1Highscore.Text!=null && textBox1Highscore.Text.Length>=3)
            {
                button1Enregistrer.Visible = true;
            }
        }
          

        /// <summary>
        /// enregistrer score si nom de 3 lettre minimum
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1Enregistrer_Click(object sender, EventArgs e)
        {      
            DialogResult = DialogResult.OK;
        }

       
    }
}
