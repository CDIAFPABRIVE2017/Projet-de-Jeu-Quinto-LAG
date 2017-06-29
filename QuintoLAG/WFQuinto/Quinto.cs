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
            alphabet = new char[26] { 'A', 'Z', 'E', 'R', 'T', 'Y', 'U', 'I', 'O', 'P', 'Q', 'S', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'W', 'X', 'C', 'V', 'B', 'N' };           
            for (lettre = 0; lettre < 10 ; lettre++)
            {               
                Button toucheClavier = new Button();                
                toucheClavier.Name = "Bouton" + alphabet[lettre].ToString();               
                //textBox1.Text = toucheClavier.Name;
                toucheClavier.Size = new System.Drawing.Size(50, 50);
                toucheClavier.Cursor = System.Windows.Forms.Cursors.Hand;
                toucheClavier.Text = alphabet[lettre].ToString();
                toucheClavier.FlatAppearance.BorderColor = System.Drawing.Color.Black;
                toucheClavier.FlatAppearance.BorderSize = 2;
                toucheClavier.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumBlue;
                toucheClavier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
                toucheClavier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                toucheClavier.UseVisualStyleBackColor = true;
                this.ClavierLigne1.Controls.Add(toucheClavier);
            }

            for (lettre = 10; lettre < 20; lettre++)
            {
                Button toucheClavier = new Button();
                toucheClavier.Name = "Bouton" + alphabet[lettre].ToString();
                //textBox1.Text = toucheClavier.Name;
                toucheClavier.Size = new System.Drawing.Size(50, 50);
                toucheClavier.Cursor = System.Windows.Forms.Cursors.Hand;
                toucheClavier.Text = alphabet[lettre].ToString();
                toucheClavier.FlatAppearance.BorderColor = System.Drawing.Color.Black;
                toucheClavier.FlatAppearance.BorderSize = 2;
                toucheClavier.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumBlue;
                toucheClavier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
                toucheClavier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                toucheClavier.UseVisualStyleBackColor = true;
                this.ClavierLigne2.Controls.Add(toucheClavier);
            }

            for (lettre = 20; lettre < 26; lettre++)
            {
                Button toucheClavier = new Button();
                toucheClavier.Name = "Bouton" + alphabet[lettre].ToString();
                //textBox1.Text = toucheClavier.Name;
                toucheClavier.Size = new System.Drawing.Size(50, 50);
                toucheClavier.Cursor = System.Windows.Forms.Cursors.Hand;
                toucheClavier.Text = alphabet[lettre].ToString();
                toucheClavier.FlatAppearance.BorderColor = System.Drawing.Color.Black;
                toucheClavier.FlatAppearance.BorderSize = 2;
                toucheClavier.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumBlue;
                toucheClavier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
                toucheClavier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                toucheClavier.UseVisualStyleBackColor = true;
                this.ClavierLigne3.Controls.Add(toucheClavier);
            }
        }
         


       
    }
}
