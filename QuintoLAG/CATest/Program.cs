﻿using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuintoLAG;
using Utilitaires;


namespace CATest
{
    class Program
    {
        static void Main(string[] args)
        {
            //testLeo();
             testLoad();
            //testScore();
        }

        private static void testScore()
        {
            Scores scores = new Scores();
         //   Score score1 = new Score() { Pseudo = "tata", Rang = 2, TopScore = 1600 };
        //    Score score2 = new Score() { Pseudo = "toto", Rang = 2, TopScore = 1500 };
        //    scores.Add(score1);
        //    scores.Add(score2);
            ISauvegarde serialiseur = new SauvegardeXML();
            scores.Load(serialiseur, Properties.Settings.Default.AppData);
            foreach (Score item in scores)
            {
                Console.WriteLine(item.Pseudo + " " + item.TopScore);
            }
            Console.ReadLine();
        }

        private static void testLoad()
        {
            //E:\CDIAlexis\Projets Collaboratifs\Projet - de - Jeu - Quinto - LAG\QuintoLAG\Data
            Dictionnaire dico = new Dictionnaire();
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

