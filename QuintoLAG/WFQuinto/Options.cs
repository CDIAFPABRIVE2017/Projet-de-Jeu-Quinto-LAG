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
        public static Options instance;
        public Options()
        {
            InitializeComponent();
        }
        public static Options CreateInstance()
        {
            if (instance == null)
            {
                instance = new Options();
            }
            return instance;
        }

        private void Options_Load(object sender, EventArgs e)
        {
            textBoxpointSeconde.Text = Properties.Settings.Default.PointsParSec.ToString();
            textBoxPointErreur.Text = Properties.Settings.Default.PointsParErreurs.ToString();
            textBoxEssaisMax.Text = Properties.Settings.Default.NbErreurMax.ToString();
            textBoxCaractereMin.Text = Properties.Settings.Default.TailleMotMin.ToString();
            textBoxCharMax.Text = Properties.Settings.Default.TailleMotMax.ToString();
            textBoxNbreManche.Text = Properties.Settings.Default.NbManches.ToString();
            //nombre manche = numericUpDownNbreManche.Value;
        }

        private void Options_FormClosed(object sender, FormClosedEventArgs e)
        {
            instance = null;
        }

        private void textBoxNbreManche_Validating(object sender, CancelEventArgs e)
        {
            if (int.Parse(textBoxNbreManche.Text) > 1 && int.Parse(textBoxNbreManche.Text) < 6)
            {
                Properties.Settings.Default.NbManches = int.Parse(textBoxNbreManche.Text);
                Properties.Settings.Default.Save();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
