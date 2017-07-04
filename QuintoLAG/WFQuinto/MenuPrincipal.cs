using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuintoLAG;

namespace WFQuinto
{
    public partial class MenuPrincipal : Form
    {
    
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Lancement nouvelle partie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Quinto quinto = new Quinto();
            quinto.MdiParent = this;
            quinto.Show();

        }


        /// <summary>
        /// Lancement options
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            Options option = new Options();
            option.MdiParent = this;

            option.Show();
            
        }


        /// <summary>
        /// Alimentation de la pioche
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AlimenterPioche_Click(object sender, EventArgs e)
        {
            AlimenterPioche alimenterPioche = AlimenterPioche.CreateInstance();
            alimenterPioche.MdiParent = this;
            alimenterPioche.Activate();
            alimenterPioche.Show();
        }

         /// <summary>
         /// Top 10 Scores
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>
        private void Scores_Click(object sender, EventArgs e)
        {
            FrmScores scores = FrmScores.CreateInstance();
            scores.MdiParent = this;
            scores.Activate();
            scores.Show(); 
        }


        /// <summary>
        /// Gestion MainMenu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aide aide = new Aide();
            aide.MdiParent = this;
            aide.Show();
        }
    }
}
