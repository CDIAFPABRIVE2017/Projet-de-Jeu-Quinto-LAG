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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            
            InitializeComponent();
        }

       


        /// <summary>
        /// nouvelle partie
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

            Quinto quinto = new Quinto();
            quinto.MdiParent = this;
            quinto.Show();
            //this.Close();

        }

        /// <summary>
        /// option
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            Options option = new Options();
            option.MdiParent = this;
            option.Show();
            //this.Close();


        }

        private void AlimenterPioche_Click(object sender, EventArgs e)
        {
            AlimenterPioche alimenterPioche = new AlimenterPioche();
            alimenterPioche.MdiParent = this;
            alimenterPioche.Show();
            //this.Close();


        }

        private void Scores_Click(object sender, EventArgs e)
        {
            Scores scores = new Scores();
            scores.MdiParent = this;
            scores.Show();
            //this.Close();



        }

        
    }
}
