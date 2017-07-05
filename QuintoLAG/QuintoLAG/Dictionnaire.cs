using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using Utilitaires;
using System.Runtime.Serialization;

namespace QuintoLAG
{
    [Serializable]
    public class Dictionnaire : HashSet<string>
    {
        protected Dictionnaire(SerializationInfo info, StreamingContext context) : base(info, context)
        { }
        private static Random rand;
        private int _tailleMotMax;
        private int _tailleMotMin;

        public int TailleMotMax
        {
            get
            {
                return _tailleMotMax;
            }

            set
            {
                _tailleMotMax = value;
            }
        }

        public int TailleMotMin
        {
            get
            {
                return _tailleMotMin;
            }

            set
            {
                _tailleMotMin = value;
            }
        }

       


        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Dictionnaire()
        {}

        public Dictionnaire(int tailleMotMax,int tailleMotMin)
        {
            rand = new Random();
            TailleMotMax = tailleMotMax;
            TailleMotMin = tailleMotMin;
        }
        public void Save(string chemin)
        {
            using (FileStream fs = new FileStream(chemin, FileMode.Create, FileAccess.Write, FileShare.Read))
            {
                StreamWriter sw = new StreamWriter(fs, Encoding.Default);
                foreach (string item in this)
                {
                    sw.WriteLine(item);
                }
                sw.Close();
                fs.Close();
            }
        }
        public void LoadTriage(string chemin)
        {
            using (FileStream fs = new FileStream(chemin, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                StreamReader sr = new StreamReader(fs, Encoding.Default);
                string strLine = sr.ReadLine();

                while (!string.IsNullOrEmpty(strLine))
                {
                    this.StringToED(Normalization(strLine).ToUpper());
                    strLine = sr.ReadLine();
                }
                sr.Close();
                fs.Close();
            }
        }


        public void StringToED(string S)
        {
            char[] delimiterChars = { ' ', ',', ';', '.', ':', '\t', '\n' };
            string[] words = S.Split(delimiterChars);

            foreach (string s in words)
            {
                if (s.Length > this.TailleMotMin && s.Length < this.TailleMotMax)
                {
                    bool test = true;
                    foreach (char caractere in s)
                    {
                        if (!char.IsLetter(caractere))
                        {
                            test = false; ;
                        }
                    }
                    if (test)
                    {
                        if (!this.Contains(s))
                            this.Add(s.ToUpper());
                    }
                }
            }
        }
        public static string Normalization(string mot)
        {
            mot = mot.Normalize(NormalizationForm.FormD);
            string motConverti = String.Empty;
            foreach (char caractere in mot)
            {
                if (char.IsLetter(caractere) || char.IsWhiteSpace(caractere))
                {
                    motConverti += (caractere.ToString());
                }
            }
            mot = motConverti;
            return mot;
        }
        public string Random()
        {
            int randcount = rand.Next(1, this.Count);
            int r = 0;
            foreach (string item in this)
            {
                if (r == randcount)
                {
                    return item;
                }
                r++;
            }
            return null;
        }
    }
}