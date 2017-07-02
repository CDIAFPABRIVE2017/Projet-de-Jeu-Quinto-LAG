using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuintoLAG
{
    public class Jeux : List<Manche>
    {
        public Scores leaderboard = new Scores();
        
        
        //   public List<Manche> manches = new List<Manche>();
        //public Manche manche = new Manche();



        #region Champs
        private int _nbreTotalManches = Properties.Settings.Default.NbManches;
        private int _nbreManches = Properties.Settings.Default.NbManches;
        private int _nbreErreurMax = Properties.Settings.Default.NbEssais;
        private bool _affichageLettre;
        private int _scoreMoyenne;
        #endregion
        #region Propriétés
        public int NbreManches
        {
            get
            {
                return _nbreManches;
            }

            set
            {
                _nbreManches = value;
            }
        }

        public int NbreErreurMax
        {
            get
            {
                return _nbreErreurMax;
            }

            set
            {
                _nbreErreurMax = value;
            }
        }
        public bool AffichageLettre
        {
            get
            {
                
                return _affichageLettre;
            }

            set
            {
                _affichageLettre = value;
            }
        }

        public int ScoreMoyenne
        {
            get
            {
                foreach (Manche item in this)
                {
                    _scoreMoyenne += item.ScoreFinManche;

                }
                if(_scoreMoyenne !=0)
                _scoreMoyenne = _scoreMoyenne / _nbreTotalManches;

                Score scorepartie = new Score() { Pseudo = "ABC", TopScore = _scoreMoyenne };
                
                leaderboard.Add(scorepartie);
                return _scoreMoyenne;
            }
            //set
            //{
            //    _scoreMoyenne = value;
            //}
        }


        #endregion
        #region Constructeurs
        public Jeux()
        {
            leaderboard.LoadScores();
        }
        public Jeux(int nbreManches, int nbreErreurMax, bool affichageLettre)
        {
            NbreManches = nbreManches;
            NbreErreurMax = nbreErreurMax;
            AffichageLettre = affichageLettre;
        }
        #endregion
        #region Méthodes
        public void NouvellePArtie()
        {
            Dictionnaire dicoload = new Dictionnaire();
            Pioches pioches = new Pioches();
            dicoload.Load(@"E:\CDIAlexis\Projets Collaboratifs\Projet-de-Jeu-Quinto-LAG\QuintoLAG\test.csv");
            Pioche unePioche = new Pioche(dicoload.Random());
            pioches.Add(unePioche);

            foreach (Pioche item in pioches)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        /// <summary>
        /// Initialise une nouvelle manche avec pioche aléatoire
        /// </summary>
        public void nouvelleManche()
        {
            this.Add(new Manche(new Pioche()));

        }

        /// <summary>
        /// Initialise une nouvelle manche
        /// </summary>
        /// <param name="motAtrouver"></param>
        public void nouvelleManche(string motAtrouver)
        {
            this.Add(new Manche(new Pioche(motAtrouver)));

        }
        #endregion
    }
}
