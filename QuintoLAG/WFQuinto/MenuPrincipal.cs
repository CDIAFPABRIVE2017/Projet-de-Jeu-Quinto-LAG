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

        private void button1_Click(object sender, EventArgs e)
        {
            Quinto quinto = new Quinto();
            quinto.MdiParent = this;
            quinto.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Options option = new Options();
            option.MdiParent = this;

            option.Show();
            
        }

        private void AlimenterPioche_Click(object sender, EventArgs e)
        {
            AlimenterPioche alimenterPioche = new AlimenterPioche();
            alimenterPioche.MdiParent = this;

            alimenterPioche.Show();
           
        }

        private void Scores_Click(object sender, EventArgs e)
        {
            Scores scores = new Scores();
            scores.MdiParent = this;
            scores.Show();
            

        }

        private void aideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aide aide = new Aide();
            aide.MdiParent = this;
            aide.Show();
        }
    }
}
