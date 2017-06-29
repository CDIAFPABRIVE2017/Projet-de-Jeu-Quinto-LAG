using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuintoLAG;

namespace CATest
{
    class Program
    {
        static void Main(string[] args)
        {



            int i = 9; //nombre de tentatives
            
            DateTime startDate = DateTime.Now;
            Pioche toto = new Pioche("lesmots");
            Manche manche = new Manche();

            Dictionnaire dico = new Dictionnaire();

            Pioches lesPioches = new Pioches();
            lesPioches.Add(toto);

            //selection aleatoire, fonctionne en hashset aussi
            Pioches randpioche = new Pioches();
            Random rand = new Random();
            int randcount = rand.Next(1, lesPioches.Count);
            int r = 0;
            foreach (Pioche item in lesPioches)
            {
                if (r == randcount)
                {
                    randpioche.Add(item);
                }
                r++;
            }
            //
            
           
            Console.WriteLine(toto);

            while (!toto.MotTrouve() && i > 0)
            {
                toto.LettreTrouve(Console.ReadKey().KeyChar);
                Console.WriteLine("\n" + toto);
                i--;
            }
            if (toto.MotTrouve())
            {
                TimeSpan ts = DateTime.Now - startDate;
                Console.WriteLine("gagné en " + ts.TotalSeconds + " s");
                Console.WriteLine((int)ts.TotalSeconds);
            }
            else
            {
                TimeSpan ts = DateTime.Now - startDate;
                Console.WriteLine("perdu en " + ts.TotalSeconds + " s");
            }
            Console.WriteLine(manche.TempsEcoule);
            Console.ReadLine();
        }
    }
}

