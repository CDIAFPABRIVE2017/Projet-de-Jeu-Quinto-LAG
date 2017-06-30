using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace WFQuinto
{
    public partial class Quinto : Form
    {

        /// <summary>
        /// initialisation chrono         
        /// </summary>
        Stopwatch watch = new Stopwatch();

        /// <summary>
        /// initialisation Formulaire
        /// </summary>
        public Quinto()
        {
            InitializeComponent();

        } 


        /// <summary>
        /// chargement de la page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Quinto_Load(object sender, EventArgs e)
        {    
             
            int lettre = 0;
            char[] alphabet;
            alphabet = new char[26] { 'A', 'Z', 'E', 'R', 'T', 'Y', 'U', 'I', 'O', 'P', 'Q', 'S', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'W', 'X', 'C', 'V', 'B', 'N' };           
            for (lettre = 0; lettre < 10 ; lettre++)
            {               
                Button toucheClavier = new Button();                
                toucheClavier.Name = "Bouton" + alphabet[lettre].ToString(); 
                toucheClavier.Size = new System.Drawing.Size(50, 50);
                toucheClavier.Cursor = System.Windows.Forms.Cursors.Hand;
                toucheClavier.Text = alphabet[lettre].ToString();


                toucheClavier.FlatAppearance.BorderColor = System.Drawing.Color.Black;
                toucheClavier.FlatAppearance.BorderSize = 2;
                toucheClavier.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumBlue;
                toucheClavier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
                toucheClavier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                toucheClavier.UseVisualStyleBackColor = true;
                toucheClavier.Click += new System.EventHandler(this.toucheClavier_Click);                 
                this.ClavierLigne1.Controls.Add(toucheClavier);
            }

            for (lettre = 10; lettre < 20; lettre++)
            {
                Button toucheClavier = new Button();
                toucheClavier.Name = "Bouton" + alphabet[lettre].ToString();  
                toucheClavier.Size = new System.Drawing.Size(50, 50);
                toucheClavier.Cursor = System.Windows.Forms.Cursors.Hand;
                toucheClavier.Text = alphabet[lettre].ToString();
                toucheClavier.FlatAppearance.BorderColor = System.Drawing.Color.Black;
                toucheClavier.FlatAppearance.BorderSize = 2;
                toucheClavier.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumBlue;
                toucheClavier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
                toucheClavier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                toucheClavier.UseVisualStyleBackColor = true;
                toucheClavier.Click += new System.EventHandler(this.toucheClavier_Click); 
                this.ClavierLigne2.Controls.Add(toucheClavier);
            }

            for (lettre = 20; lettre < 26; lettre++)
            {
                Button toucheClavier = new Button();
                toucheClavier.Name = "Bouton" + alphabet[lettre].ToString();                  
                toucheClavier.Size = new System.Drawing.Size(50, 50);
                toucheClavier.Cursor = System.Windows.Forms.Cursors.Hand;
                toucheClavier.Text = alphabet[lettre].ToString();
                toucheClavier.FlatAppearance.BorderColor = System.Drawing.Color.Black;
                toucheClavier.FlatAppearance.BorderSize = 2;
                toucheClavier.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumBlue;
                toucheClavier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
                toucheClavier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                toucheClavier.UseVisualStyleBackColor = true;
                toucheClavier.Click += new System.EventHandler(this.toucheClavier_Click);  
                this.ClavierLigne3.Controls.Add(toucheClavier);
            }

            
        }    
        

        #region chrono

        /// <summary>
        /// lancement chrono(debut manche)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {               
            watch.Start();
        }
        /// <summary>
        /// arret chrono (fin de manche)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            watch.Stop();
            TimeSpan tempsFinal = watch.Elapsed;

            labelTempsFinal.Text = tempsFinal.ToString(@"hh\:mm\:ss");
        }
        
        /// <summary>
        /// Gestion du timer (rafraichissment horloge a la seconde)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>                     
        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan tempsReel = watch.Elapsed;
            labelTempsReel.Text = tempsReel.ToString(@"hh\:mm\:ss");
        }   
    
        #endregion
        
                
        #region saisie clavier

        /// <summary>
        /// Saisie clavier physique
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Quinto_KeyPress(object sender, KeyPressEventArgs e)
        {

            //gestion clavier ligne 1---------------------------------
            foreach (Control bouton in ClavierLigne1.Controls)
            {
                    if (bouton.Text.ToLower() == e.KeyChar.ToString())
                    {
                        toucheClavier_Click(bouton, e);
                    }
            }
            //---------------------------------------------------------



            //gestion clavier ligne 2----------------------------------
            foreach (Control bouton in ClavierLigne2.Controls)
            {
                if (bouton.Text.ToLower() == e.KeyChar.ToString())
                {
                    toucheClavier_Click(bouton, e);
                }
            }
            //---------------------------------------------------------



            //gestion clavier ligne 3----------------------------------
            foreach (Control bouton in ClavierLigne3.Controls)
            {
                if (bouton.Text.ToLower() == e.KeyChar.ToString())
                {
                    toucheClavier_Click(bouton, e);
                }
            }
            //---------------------------------------------------------



        }

        /// <summary>
        /// saisie clavier virtuel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toucheClavier_Click(object sender, EventArgs e)
        {   
            //réaffichage des boutons utilisés
            Button buttonCopie = new Button();
            buttonCopie.Text = ((Button)sender).Text;
            buttonCopie.Size = new System.Drawing.Size(50, 50);
            buttonCopie.Cursor = System.Windows.Forms.Cursors.No;
            toucheUtilisées.Controls.Add(buttonCopie);

            //modification graphique des boutons utilisés
            ((Button)sender).Enabled = false;
            ((Button)sender).Cursor = System.Windows.Forms.Cursors.No;
            ((Button)sender).FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            ((Button)sender).FlatAppearance.BorderSize = 1;
            ((Button)sender).FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            ((Button)sender).FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ((Button)sender).UseVisualStyleBackColor = true;
            label3.Text = ((Button)sender).Text; //test ecriture clavier virtuel
                       
        }

        #endregion


        /// <summary>
        /// numeric updown pour tester incrementation erreur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
            switch (numericUpDown1.Value.ToString())
            {

                case "0":
                    pictureBox1.Image = WFQuinto.Properties.Resources.potence;                    
                    break; 
                case "1":
                    pictureBox1.Image = WFQuinto.Properties.Resources._1;
                    break;
                case "2":
                    pictureBox1.Image = WFQuinto.Properties.Resources._2;
                    break;
                case "3":
                    pictureBox1.Image = WFQuinto.Properties.Resources._3;
                    break;
                case "4":
                    pictureBox1.Image = WFQuinto.Properties.Resources._4;
                    break;
                case "5":
                    pictureBox1.Image = WFQuinto.Properties.Resources._5;
                    break;
                case "6":
                    pictureBox1.Image = WFQuinto.Properties.Resources._6;
                    break;
                case "7":
                    pictureBox1.Image = WFQuinto.Properties.Resources._7;
                    break;
                case "8":
                    pictureBox1.Image = WFQuinto.Properties.Resources._8;
                    break;
                case "9":
                    pictureBox1.Image = WFQuinto.Properties.Resources._9;
                    break;
                case "perdu":
                    pictureBox1.Image = WFQuinto.Properties.Resources.Rsod;

                    break;

                default:
                   
                    break;
                    
            }

        }


    }
}
