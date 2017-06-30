﻿using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuintoLAG;
using Utilitaires;
using System.Diagnostics;



namespace CATest
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionnaire ledico = new Dictionnaire();
           
            //ISauvegarde serialiseur = MonApplication.DispositifSauvegarde;
           // salaries.Load(serialiseur, Properties.Settings.Default.AppData);


            Stopwatch watch = new Stopwatch();
            watch.Start();
            //testLeo();
             //testLoad();
            testScore();
        }

        private static void testScore()
        {
            Scores scores = new Scores();
            /* 
            Score score1 = new Score() { Pseudo = "Alan", TopScore = 1600 };
            Score score2 = new Score() { Pseudo = "Bernard", TopScore = 1200 };
            Score score3 = new Score() { Pseudo = "Christian", TopScore = 555 };
            Score score4 = new Score() { Pseudo = "Dani", TopScore = 1320 };
            Score score5 = new Score() { Pseudo = "Eric", TopScore = 348 };
            Score score6 = new Score() { Pseudo = "Fabien", TopScore = 500 };
            Score score7 = new Score() { Pseudo = "Germaine", TopScore = 2600 };
            Score score8 = new Score() { Pseudo = "Hector", TopScore = 1500 };
            Score score9 = new Score() { Pseudo = "Isabelle", TopScore = 1600 };
            Score score10 = new Score() { Pseudo = "Julie", TopScore = 150 };
            Score score11 = new Score() { Pseudo = "Kader", TopScore = 160 };
            Score score12 = new Score() { Pseudo = "Lionel", TopScore = 150 };
            scores.Add(score1);
            scores.Add(score2);
            scores.Add(score3);
            scores.Add(score4);
            scores.Add(score5);
            scores.Add(score6);
            scores.Add(score7);
            scores.Add(score8);
            scores.Add(score9);
            scores.Add(score10);
            scores.Add(score11);
            scores.Add(score12);*/

            // scores.Sort(); //compare to fonctionne

            ISauvegarde serialiseur = new SauvegardeXML();
            scores.Load(serialiseur, Properties.Settings.Default.AppData);

            //foreach (Score score in scores)
            //{
            //    Console.WriteLine(score);
            //}

    

                Console.WriteLine(scores);
            Console.ReadLine();

        }

        private static void testLoad()
        {
            //E:\CDIAlexis\Projets Collaboratifs\Projet - de - Jeu - Quinto - LAG\QuintoLAG\Data
            Dictionnaire dico = new Dictionnaire();

            //dico.Load(@"C:\Users\x_pan\Google Drive\exos\visualstudio\Projet-de-Jeu-Quinto-LAG\QuintoLAG\liste_francais.csv");
            
            dico.Load(@"E:\CDIAlexis\Projets Collaboratifs\Projet-de-Jeu-Quinto-LAG\QuintoLAG\liste_francais.csv");
            foreach (string item in dico)
            {
                Console.WriteLine(item);
            }
            dico.Save(@"E:\CDIAlexis\Projets Collaboratifs\Projet-de-Jeu-Quinto-LAG\QuintoLAG\test.csv");

            Console.ReadLine();

        }

        static void testLeo()
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

