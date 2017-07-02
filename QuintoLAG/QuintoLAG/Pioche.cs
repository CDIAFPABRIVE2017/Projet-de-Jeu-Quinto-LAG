using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuintoLAG
{
    public class Pioche
    {
        #region Champs
        private string _mot;
        private string _definition;
        private bool[] _charDecouverts;
        private int _erreurs;
        #endregion
        #region Propriétés
        public string Mot
        {
            get
            {
                return _mot;
            }

            set
            {
                _mot = value;
            }
        }

        public string Definition
        {
            get
            {
                return _definition;
            }

            set
            {
                _definition = value;
            }
        }

        public bool[] CharDecouverts
        {
            get
            {
                return _charDecouverts;
            }

            set
            {
                _charDecouverts = value;
            }
        }

        public int Erreurs { get => _erreurs; set => _erreurs = value; }
        #endregion

        #region Constructeurs
        public Pioche()
        { }
        public Pioche(string motATrouver)
        {
            Mot = motATrouver.ToUpper();
            int lenght = Mot.Length;
            CharDecouverts = new bool[lenght];
        }
        #endregion


        #region Méthodes

        public bool LettreTrouve(char c)
        {
            c = char.ToUpper(c);
            if (Mot.Contains(c))
            {
                for (int i = 0; i < Mot.Length; i++)
                {
                    if (Mot[i] == c)
                        CharDecouverts[i] = true;
                }
                return true;
            }
            Erreurs++;
            return false;
        }

        public bool MotTrouve()
        {
            foreach (var item in CharDecouverts)
            {
                if (item == false)
                    return false;
            }
            return true;
        }

        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < Mot.Length; i++)
            {
                if (CharDecouverts[i])
                    s += Mot[i];
                else
                    s += "_";
            }
            return s;
        }
        #endregion
    }
}
