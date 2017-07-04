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
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        private void Options_Load(object sender, EventArgs e)
        {
            textBoxpointSeconde.Text = Properties.Settings.Default.PointsParSec.ToString() ;
            textBoxPointErreur.Text = Properties.Settings.Default.PointsParErreurs.ToString();
            textBoxEssaisMax.Text = Properties.Settings.Default.NbEssais.ToString();
            textBoxCaractereMin.Text = Properties.Settings.Default.TailleMotMin.ToString();
            textBoxCharMax.Text = Properties.Settings.Default.TailleMotMax.ToString();
            textBoxNbreManche.Text = Properties.Settings.Default.NbManches.ToString();
            //nombre manche = numericUpDownNbreManche.Value;
        }
    }
}
