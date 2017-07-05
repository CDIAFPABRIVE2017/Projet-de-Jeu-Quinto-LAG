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
    public partial class Aide : Form
    {
        public static Aide instance;
        public Aide()
        {
            InitializeComponent();
        }
        public static Aide CreateInstance()
        {
            if (instance==null)
            {
                instance = new Aide();
            }
            return instance;
        }

        private void Aide_FormClosed(object sender, FormClosedEventArgs e)
        {
            instance = null;
        }
    }
}