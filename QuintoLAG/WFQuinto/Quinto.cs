﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using QuintoLAG;


namespace WFQuinto
{
    public partial class Quinto : Form
    {
        enum Contextes
        {
            Initial = 0,
            NouvelleManche = 1,
        }
        void GestionnaireContextes(Contextes contexte)
        {
            switch (contexte)
            {
                case Contextes.Initial:

                    break;
                case Contextes.NouvelleManche:
                    ClavierLigne1.Controls.Clear();
                    ClavierLigne2.Controls.Clear();
                    ClavierLigne3.Controls.Clear();
                    GenererClavier();
                    manche = new Manche(new Pioche(MonApplication.Dictionnaire.Random()), Properties.Settings.Default.NbManches, Properties.Settings.Default.NbErreurMax, Properties.Settings.Default.PointsParSec, Properties.Settings.Default.PointsParErreurs);
                    //manche = new Manche(new Pioche("Soleil"));
                    refresh();
                    partie.Add(manche);
                    mancheNombreManche.Text = partie.Count + "/" + partie.NbreManches;
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// initialisation Formulaire
        /// </summary>
        public Quinto()
        {
            InitializeComponent();
        }
        Jeux partie = new Jeux(Properties.Settings.Default.NbManches, Properties.Settings.Default.NbErreurMax, Properties.Settings.Default.PointsParSec, Properties.Settings.Default.PointsParErreurs);
        Manche manche;

        private void refresh()
        {
            label2nbreErreur.Text = manche.NbreErreur.ToString();
            labelMotaDeviner.Text = manche.Pioche.ToString();
        }
        /// <summary>
        /// chargement de la page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Quinto_Load(object sender, EventArgs e)
        {
            GestionnaireContextes(Contextes.NouvelleManche);
            label2nbreErreur.Text = "0";
        }

        private void GenererClavier()
        {
            int lettre = 0;
            char[] alphabet;
            alphabet = new char[26] { 'A', 'Z', 'E', 'R', 'T', 'Y', 'U', 'I', 'O', 'P', 'Q', 'S', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'W', 'X', 'C', 'V', 'B', 'N' };
            for (lettre = 0; lettre < 10; lettre++)
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
        /// <summary>
        /// Gestion du timer (rafraichissment horloge a la seconde)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>                     
        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTempsReel.Text = manche.TempsManche.ToString(@"hh\:mm\:ss");
            label2ScoreTotal.Text = manche.ScoreManche.ToString();
        }
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
                if (bouton.Text.ToLower() == e.KeyChar.ToString() & (bouton.Enabled != false))
                {
                    toucheClavier_Click(bouton, e);
                }
            }
            //---------------------------------------------------------

            //gestion clavier ligne 2----------------------------------
            foreach (Control bouton in ClavierLigne2.Controls)
            {
                if (bouton.Text.ToLower() == e.KeyChar.ToString() & (bouton.Enabled != false))
                {
                    toucheClavier_Click(bouton, e);
                }
            }
            //---------------------------------------------------------

            //gestion clavier ligne 3----------------------------------
            foreach (Control bouton in ClavierLigne3.Controls)
            {
                if (bouton.Text.ToLower() == e.KeyChar.ToString() & (bouton.Enabled != false))
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
            //réaffichage des boutons utilisés dans un autre label
            Button buttonCopie = new Button();
            buttonCopie.Text = ((Button)sender).Text;
            buttonCopie.Size = new System.Drawing.Size(40, 40);
            buttonCopie.Cursor = System.Windows.Forms.Cursors.No;
            toucheUtilisées.Controls.Add(buttonCopie);
            ///modification graphique des boutons utilisés
            ((Button)sender).Enabled = false;
            ((Button)sender).Cursor = System.Windows.Forms.Cursors.No;
            ((Button)sender).FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            ((Button)sender).FlatAppearance.BorderSize = 1;
            ((Button)sender).FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            ((Button)sender).FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ((Button)sender).UseVisualStyleBackColor = true;

            char c = Char.Parse(((Button)sender).Text);
            manche.Pioche.LettreTrouve(c);
            refresh();

            if (manche.MancheTermine)
            {
                manche.FinManche = DateTime.Now;

                if (manche.MancheGagne)
                {
                    PartieGagnee DialogueModalFRMPartieGagnee = new PartieGagnee();
                    DialogResult Victoire = DialogueModalFRMPartieGagnee.ShowDialog();
                    switch (Victoire)
                    {
                        case DialogResult.None:
                            DialogueModalFRMPartieGagnee.ShowDialog();
                            break;
                        case DialogResult.OK:
                            if (partie.Count == partie.NbreManches)
                            {
                                if (MonApplication.Highscores.IsLeaderBoard(partie.ScoreMoyenne))
                                {
                                    highScoreInput entrezNom = new highScoreInput();
                                    DialogResult nom = entrezNom.ShowDialog();
                                    if (nom == DialogResult.OK)
                                    {
                                        MonApplication.Highscores.addLeaderBoard(entrezNom.pseudo, partie.ScoreMoyenne);
                                        entrezNom.Close();
                                    }

                                }

                                this.Close();
                            }
                            GestionnaireContextes(Contextes.NouvelleManche);
                            break;
                        case DialogResult.Cancel:
                            this.Close();
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    // watch.Stop();
                    // TimeSpan tempsFinal = watch.Elapsed;
                    // labelTempsFinal.Text = tempsFinal.ToString(@"hh\:mm\:ss");

                    PartiePerdue DialogueModalFRMPartiePerdue = new PartiePerdue();
                    DialogResult Gameover = DialogueModalFRMPartiePerdue.ShowDialog();
                    switch (Gameover)
                    {
                        case DialogResult.None:
                            DialogueModalFRMPartiePerdue.ShowDialog();
                            break;
                        case DialogResult.OK:
                            DialogueModalFRMPartiePerdue.Close();
                            this.Close();
                            break;
                        case DialogResult.Cancel:
                            DialogueModalFRMPartiePerdue.Close();
                            break;
                        case DialogResult.Abort:
                            DialogueModalFRMPartiePerdue.Close();
                            break;
                    }
                }
            }
        }
        #endregion
        /// <summary>
        /// Lien image/erreur
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label2nbreErreur_TextChanged(object sender, EventArgs e)
        {
            switch (label2nbreErreur.Text)
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
            }
        }
    }
}
