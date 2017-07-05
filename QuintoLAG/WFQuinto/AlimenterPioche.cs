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
using System.IO;
namespace WFQuinto
{
    public partial class AlimenterPioche : Form
    {
        static AlimenterPioche instance;
        private AlimenterPioche()
        {
            InitializeComponent();
        }
        public static AlimenterPioche CreateInstance()
        {
            if (instance == null)
            {
                instance = new AlimenterPioche();
            }
            return instance;

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void butCharger_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Dictionnaire dico = new Dictionnaire();
                dico.LoadTriage(openFileDialog1.FileName);
                foreach (var item in dico)
                {
                    lBoxDictionnaire.Items.Add(item);
                }
            }
        }

        private void butSauvegarde_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = "csv";
            saveFileDialog1.Filter = "Text files (*.csv)|*.csv|All files (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK && lBoxPioche.Items.Count > 1)
            {
                MonApplication.Dictionnaire.Clear();
                foreach (var item in lBoxPioche.Items)
                {
                    MonApplication.Dictionnaire.Add(item.ToString());
                }
                MonApplication.Dictionnaire.Save(saveFileDialog1.FileName);
            }
        }

        private void butToutAjouter_Click(object sender, EventArgs e)
        {
            foreach (var item in lBoxDictionnaire.Items)
            {
                lBoxPioche.Items.Add(item.ToString());
            }
        }

        private void AlimenterPioche_FormClosed(object sender, FormClosedEventArgs e)
        {
            instance = null;
        }

        private void butViderListDictionnaire_Click(object sender, EventArgs e)
        {
            lBoxDictionnaire.Items.Clear();
        }

        private void butViderListePioche_Click(object sender, EventArgs e)
        {
            lBoxPioche.Items.Clear();
        }

        private void butAjouterSelection_Click(object sender, EventArgs e)
        {
            foreach (var item in lBoxDictionnaire.SelectedItems)
            {
                lBoxPioche.Items.Add(item.ToString());
            }
        }

        private void butRetirer_Click(object sender, EventArgs e)
        {
            while (lBoxPioche.SelectedIndex != -1)
            {
                lBoxPioche.Items.RemoveAt(lBoxPioche.SelectedIndex);
            }
        }

        private void butMot_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tBoxMot.Text) && Dictionnaire.Normalization(tBoxMot.Text.ToUpper()).Length >= 5)
            {
                lBoxPioche.Items.Add(Dictionnaire.Normalization(tBoxMot.Text.ToUpper()));
            }
        }
    }
}
