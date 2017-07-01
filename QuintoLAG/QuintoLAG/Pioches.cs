using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitaires;

namespace QuintoLAG
{
    public class Pioches : HashSet<Pioche>
    {
        public Pioches()
        { }

        //selection aleatoire, fonctionne en hashset aussi

        ///onfait cela dans Pioche sans "S"
        //public string PiocheRand(Dictionnaire dico)
        //{
        //    Pioches randpioche = new Pioches();
        //    Random rand = new Random();
        //    int randcount = rand.Next(1, dico.Count);
        //    int r = 0;
        //    foreach (string item in dico)
        //    {
        //        if (r == randcount)
        //        {
        //            Pioche pioche = new Pioche(item);
        //            randpioche.Add(pioche);
        //        }
        //        r++;
        //    }
        //    return null;
        //}
    }
}
