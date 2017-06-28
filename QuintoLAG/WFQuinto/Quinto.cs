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
    public partial class Quinto : Form
    {
        public Quinto()
        {
            InitializeComponent();
        }

        private void Quinto_Load(object sender, EventArgs e)
        {
            int lettre = 0;
            char[] alphabet;
            alphabet = new char[26] {'A','Z','E', 'R', 'T', 'Y', 'U', 'I','O','P','Q', 'S', 'D', 'F', 'G', 'H', 'J', 'K', 'L','M', 'W','X', 'C','V','B','N'};
            int couleurAlternance = 10; 
            { for (lettre = 0; lettre < alphabet.Length - 1; lettre++)
                {
                    int modulo = (lettre + couleurAlternance) % 2;
                    Button toucheClavier = new Button();
                    this.PanelClavier.Controls.Add(toucheClavier);
                    if (modulo==0)
                    {
                        toucheClavier.BackColor = Color.Gray;
                    }

                    else
                    {
                        toucheClavier.BackColor = Color.DarkGray;
                    }
                    toucheClavier.Name = "Button" +alphabet[lettre].ToString();
                    textBox1.Text = toucheClavier.Name;
                    toucheClavier.Size = new System.Drawing.Size(50, 50);
                    toucheClavier.Cursor = System.Windows.Forms.Cursors.Hand;
                    toucheClavier.Text = alphabet[lettre].ToString();
                    //this.PanelClavier.Controls.Add(toucheClavier);
                   
                }

            }
            
        }
    }
}
