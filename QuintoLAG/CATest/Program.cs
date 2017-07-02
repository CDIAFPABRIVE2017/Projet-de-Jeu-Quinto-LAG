using System;
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
            //salaries.Load(serialiseur, Properties.Settings.Default.AppData);


            testLeo();
           // testLoad();
            // testScore();
            // Jeux jeux = new Jeux(2, 9, true);
            // jeux.NouvellePArtie();
        }

        #region testScore
        private static void testScore()
        {
            Scores scores = new Scores();

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
            scores.Add(score12);

            Console.WriteLine("Les scores sont :");
            Console.WriteLine(scores);

            ISauvegarde serialiseur = new SauvegardeXML();
            scores.Save(serialiseur, Properties.Settings.Default.AppData);

            Console.WriteLine("Les scores chargés sont :");
            Scores scoresLoad = new Scores();


            scoresLoad.Load(serialiseur, Properties.Settings.Default.AppData);
            Console.WriteLine(scoresLoad);


            //foreach (Score score in scoresLoad)
            //{
            //    Console.WriteLine(score);
            //}

            Console.ReadLine();

        }
        #endregion

        private static void testLoad()
        {
            //E:\CDIAlexis\Projets Collaboratifs\Projet - de - Jeu - Quinto - LAG\QuintoLAG\Data
            Dictionnaire dico = new Dictionnaire();

            //dico.Load(@"C:\Users\x_pan\Google Drive\exos\visualstudio\Projet-de-Jeu-Quinto-LAG\QuintoLAG\liste_francais.csv");
            dico.LoadTriage(@"C:\Users\leopard\Documents\GitHub\Projet-de-Jeu-Quinto-LAG\QuintoLAG\liste_francais.csv");
            
            //dico.Load(@"E:\CDIAlexis\Projets Collaboratifs\Projet-de-Jeu-Quinto-LAG\QuintoLAG\liste_francais.csv");
            foreach (string item in dico)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Selection random :");
            string test =dico.Random();
            Console.WriteLine(test);
 

            dico.Save(@"C:\Users\leopard\Documents\GitHub\Projet-de-Jeu-Quinto-LAG\QuintoLAG\test.csv");
            //dico.Save(@"E:\CDIAlexis\Projets Collaboratifs\Projet-de-Jeu-Quinto-LAG\QuintoLAG\test.csv");
            Console.ReadLine();

        }

        static void testLeo()
        {
            Dictionnaire dico = new Dictionnaire();
            dico.LoadTriage(@"C:\Users\leopard\Documents\GitHub\Projet-de-Jeu-Quinto-LAG\QuintoLAG\liste_francais.csv");
     

           // Pioche toto = new Pioche(dico.Random());

            Jeux partie = new Jeux();

            while (partie.NbreManches>0)
            {
                
                //Manche manche = new Manche(new Pioche(dico.Random()));
                Manche manche = new Manche(new Pioche("SOLEIL"));
                Console.WriteLine(manche.Pioche);
                while (!manche.MancheGagne && manche.NbreErreurMax > manche.NbreErreur)
                {


                    manche.Pioche.LettreTrouve(Console.ReadKey().KeyChar);
  

                    Console.WriteLine("\n" + manche.NbreErreur);
                    Console.WriteLine("\n" + manche.Pioche);
                   // manche.NbreErreurMax--;
                }

                //si le mot est trouvé (fin de partie...)
                if (manche.MancheGagne)
                {
                    Console.WriteLine("gagné en " + manche.CurrentTempsEcoule + " s");
                    Console.WriteLine("score : " + manche.ScoreFinManche + " // currentscore : " + manche.CurrentScore);
                    Console.WriteLine("Temps : " + manche.TempsFinManche);
                    //bloc en dessous juste pour check la non evolution du temps, a supprimer un fois reglé
                    Console.WriteLine("laisson ecouler du temps...");
                    Console.ReadLine();
                    Console.WriteLine("score : " + manche.ScoreFinManche + " // currentscore : " + manche.CurrentScore);
                    Console.WriteLine("Temps : " + manche.TempsFinManche);

                }
                else
                {
                    Console.WriteLine("perdu en " + manche.CurrentTempsEcoule + " s");
                    Console.WriteLine("score : " + manche.ScoreFinManche);
                }

                partie.NbreManches--;
                Console.ReadLine();
                //bloc en dessous juste pour check la non evolution du temps, a supprimer un fois reglé
                if (!manche.MancheGagne)
                {
                    Console.WriteLine("manche.MancheGagne perdu en " + manche.CurrentTempsEcoule + " score : "+ manche.ScoreFinManche);
                }
            }

        }
    }
}

