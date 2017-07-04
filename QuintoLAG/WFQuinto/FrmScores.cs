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
using Utilitaires;

namespace WFQuinto
{
    public partial class FrmScores : Form
    {
        public FrmScores()
        {
            InitializeComponent(); 
        }  
        
        /// <summary>
       /// Chargement et affichage des 10 meilleurs scores
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void FrmScores_Shown(object sender, EventArgs e)
        {
            ISauvegarde serialiseur = new SauvegardeXML();
            Scores scoresLb = new Scores();
            scoresLb.Load(serialiseur, Properties.Settings.Default.AppData);
            textBox1top10.Text = scoresLb.ToString();

        }
    }
}
