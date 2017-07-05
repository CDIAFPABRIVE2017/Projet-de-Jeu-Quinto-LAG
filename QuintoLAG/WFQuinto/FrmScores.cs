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
        static FrmScores instance;
        private FrmScores()
        {
            InitializeComponent();
        }
       public static FrmScores CreateInstance()
        {
            if (instance==null)
            {
                instance = new FrmScores();
            }
            return instance;
        }
        
        /// <summary>
       /// Chargement et affichage des 10 meilleurs scores
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void FrmScores_Shown(object sender, EventArgs e)
        {
            textBox1top10.Text = MonApplication.Highscores.ToString();
        }

        private void FrmScores_FormClosed(object sender, FormClosedEventArgs e)
        {
            instance = null;
        }
    }
}
