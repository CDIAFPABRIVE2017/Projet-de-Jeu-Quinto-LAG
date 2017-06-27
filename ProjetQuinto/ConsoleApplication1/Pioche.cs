using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Pioche
    {
        private string Mot;
        private string Définition;
        private bool[] charDecouverts;
        private string mot;

        public Pioche(string motATrouver)
        {
            mot = motATrouver;
            int lenght = mot.Length;
            charDecouverts = new bool[lenght];
        }

        public Boolean LettreTrouve(Char c)
        {
            if (mot.Contains(c))
            {
                for (int i = 0; i < mot.Length; i++)
                {
                    if (mot[i] == c)
                        charDecouverts[i] = true;
                }
                return true;
            }
            return false;
        }

        public Boolean MotTrouve()
        {
            foreach (var item in charDecouverts)
            {
                if (item == false)
                    return false;
            }
            return true;
        }

        public override String ToString()
        {
            String s = "";
            for (int i = 0; i < mot.Length; i++)
            {
                if (charDecouverts[i])
                    s += mot[i];
                else
                    s += "_";
            }
            return s;
        }
    }

}