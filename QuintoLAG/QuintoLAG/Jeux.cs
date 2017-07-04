using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuintoLAG
{
    public class Jeux : List<Manche>
    {
        public Scores leaderboard = new Scores();
        
        #region Champs
        private int _nbreManches = Properties.Settings.Default.NbManches;
        private int _nbreErreurMax = Properties.Settings.Default.NbEssais;
        private bool _affichageLettre;
        private int _scoreMoyenne;
        private int scoreTotal;
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
                scoreTotal = 0;
                foreach (Manche item in this)
                {
                    scoreTotal += item.ScoreManche;

                }
                return (scoreTotal / _nbreManches);
            }
        }
        #endregion
        #region Constructeurs
        public Jeux()
        { }
        public Jeux(int nbreManches, int nbreErreurMax, bool affichageLettre)
        {
            NbreManches = nbreManches;
            NbreErreurMax = nbreErreurMax;
            AffichageLettre = affichageLettre;
        }
        #endregion
        #region Méthodes

        /// <summary>
        /// Initialise une nouvelle manche avec pioche aléatoire
        /// </summary>
        public void NouvelleManche()
        {
            this.Add(new Manche(new Pioche()));
        }

        /// <summary>
        /// Initialise une nouvelle manche
        /// </summary>
        /// <param name="motAtrouver"></param>
        public void NouvelleManche(string motAtrouver)
        {
            this.Add(new Manche(new Pioche(motAtrouver)));
        }
        
        #endregion
    }
}
