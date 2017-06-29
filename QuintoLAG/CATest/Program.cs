using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuintoLAG;
using System.Diagnostics;


namespace CATest
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            int i = 9; //nombre de tentatives
            
            DateTime startDate = DateTime.Now;
            Pioche toto = new Pioche("lesmots");
            Manche manche = new Manche();
           
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
                Console.WriteLine("gagné en " + ts.Minutes + " s");
                Console.WriteLine((int)ts.TotalSeconds);
            }
            else
            {
                TimeSpan ts = DateTime.Now - startDate;
                Console.WriteLine("perdu en " + ts.TotalSeconds + " s");
            }
            watch.Stop();
            TimeSpan time = watch.Elapsed;
            Console.WriteLine("temps ecoulé" + time);
            Console.WriteLine(manche.TempsEcoule);
            Console.ReadLine();
        }
    }
}

