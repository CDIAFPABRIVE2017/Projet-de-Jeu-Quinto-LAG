using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using Utilitaires;


namespace QuintoLAG
{
    [Serializable]
    public class Dictionnaire : List<string>
    {

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Dictionnaire()
        { }
        public void Save(string chemin)
        {
            using (FileStream fs = new FileStream(chemin, FileMode.Truncate, FileAccess.Write, FileShare.Read))
            {
                StreamWriter sw = new StreamWriter(fs);
                foreach (string item in this)
                {
                    sw.WriteLine(item);
                }
                sw.Close();
                fs.Close();
            }
        }
        public void Load(string chemin)
        {
            using (FileStream fs = new FileStream(chemin, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                StreamReader sr = new StreamReader(fs, Encoding.Default);
                string strLine = Normalization(sr.ReadLine());

                while (!string.IsNullOrEmpty(strLine))
                {
                    this.stringToED(Normalization(strLine).ToUpper());
                    strLine = sr.ReadLine();
 
                }
                sr.Close();
                fs.Close();
            }
        }
        public void stringToED(string S)
        {
            //char[] delimiterChars = { ' ', ',', '.', ':', '\t', '\n' };
            //string[] words = S.Split(delimiterChars);

            //foreach (string s in words)
            //{
            //    if (s.Length > 4 && s.Length < 25)
            //    {
            //        bool test = true;
            //        foreach (char caractere in s)
            //        {
            //            if (!char.IsLetter(caractere))
            //            {
            //                test = false; ;
            //            }
            //        }
            //        if (test)
            //        {
            //            if (!this.Contains(s))
            //                this.Add(s.ToUpper());
            //        }
            //    }
            //}

            for (int i = 0; i < S.Length && S.Length > 4; i++)
            {
                if (char.IsLetter(S[i]))
            {
                for (int j = i; j < S.Length && char.IsLetter(S[j]); j++)
                {
                    if (j >= i + 4 && ((j == S.Length - 1) || !char.IsLetter(S[j])))
                    {
                        string chaine = S[i].ToString();
                        for (i++; i <= j; i++)
                        {
                            chaine += S[i];
                        }
                        if (!this.Contains(chaine))
                        {

                            this.Add(chaine.ToUpper());
                        }
                    }
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

    }
}