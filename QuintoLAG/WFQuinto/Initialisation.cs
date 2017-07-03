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
    public partial class Initialisation : Form
    {
        public Initialisation()
        {
            InitializeComponent();
            Options option = new Options();
            option.MdiParent = this;

        }

        private void Initialisation_Load(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.MdiParent = this;
            menuPrincipal.Show();            

        }
    }
}
