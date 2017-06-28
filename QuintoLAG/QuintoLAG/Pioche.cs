using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuintoLAG
{
    public class Pioche
    {
        private string _mot;
        private string _definition;
        private bool[] _charDecouverts;

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
        public Pioche(string motATrouver)
        {
            Mot = motATrouver;
            int lenght = Mot.Length;
            CharDecouverts = new bool[lenght];
        }

        public bool LettreTrouve(char c)
        {
            if (Mot.Contains(c))
            {
                for (int i = 0; i < Mot.Length; i++)
                {
                    if (Mot[i] == c)
                        CharDecouverts[i] = true;
                }
                return true;
            }
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
    }
}
