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


            /////
            button1Record.Visible = true;
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


       /// <summary>
       /// partie gagnée avec meilleur score  et ouvre frm Highscore
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
       /// Permuter les hide selon le cas
       /// 
        private void button1Record_Click(object sender, EventArgs e)
        {
            HighScore DialogueModalFRMhighscore = new HighScore();
            DialogResult highscore = DialogueModalFRMhighscore.ShowDialog();
            switch (highscore)
            {
                case DialogResult.None:
                    DialogueModalFRMhighscore.ShowDialog();
                    break;
                case DialogResult.OK:
                    DialogueModalFRMhighscore.Close();
                    
                    break;
                case DialogResult.Cancel:
                    DialogueModalFRMhighscore.ShowDialog();
                    break;
                case DialogResult.Abort:
                    DialogueModalFRMhighscore.ShowDialog();
                    break;
            }

           
        }

       
    }
}
