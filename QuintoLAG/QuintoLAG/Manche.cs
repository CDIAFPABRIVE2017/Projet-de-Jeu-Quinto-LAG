using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuintoLAG
{
    public class Manche : Jeux
    {
        #region Champs
        private Pioche _pioche;
        private int _nbreErreur;
        private int _scoreFinManche;
        private DateTime _debutManche;
        private DateTime _finManche;

        private TimeSpan _tempsFinManche;
       // private bool _mancheGagne;
        private bool _mancheTermine = false;

        #endregion
        #region Propriétés
        public Pioche Pioche
        {
            get
            {
                return _pioche;
            }

            set
            {
                _pioche = value;
            }
        }

        public int NbreErreur
        {
            get
            {
                return Pioche.Erreurs;
            }

            set
            {
                _nbreErreur = value;
            }
        }

        public TimeSpan CurrentTempsEcoule
        {
            get
            {
                return DateTime.Now - DebutManche;
            }
        }
        public int CurrentScore
        {
            get
            {

                return (((int)CurrentTempsEcoule.TotalSeconds* Properties.Settings.Default.PointsParSec) + (Properties.Settings.Default.PointsParErreurs * NbreErreur));
            }
        }

        public DateTime DebutManche
        {
            get
            {
                return _debutManche;
            }

            set
            {
                _debutManche = value;
            }
        }

        public DateTime FinManche
        {
            get
            {
                return _finManche;
            }

            set
            {
                _finManche = value;
            }
        }

        public TimeSpan TempsManche
        {
            get
            {
                return FinManche - DebutManche;
            }
        }

        public bool MancheGagne
        {


            get
            {
                if (Pioche.MotTrouve() && !_mancheTermine)
                {
                    //ScoreFinManche = CurrentScore;
                    _scoreFinManche = CurrentScore;
                    TempsFinManche = CurrentTempsEcoule;
                    _mancheTermine = true;
                }
               


                return Pioche.MotTrouve();
            }

          //  set => _mancheGagne = value;
        }

        public int ScoreFinManche
        {
            get
            {
                return _scoreFinManche;
            }
            set
            {
                _scoreFinManche = value;
            }
       }
        public TimeSpan TempsFinManche
        {
            get
            {
                return _tempsFinManche;
            }
            set
            {
                _tempsFinManche = value;
            }
         }

        #endregion
        #region Constructeurs
        public Manche()
        {
            DebutManche = DateTime.Now;
        }
        /// <summary>
        /// Initialise une nouvelle manche
        /// </summary>
        /// <param name="pioche">instance de l'objet Pioche</param>
        public Manche(Pioche pioche)
        {
            Pioche = pioche;
            NbreErreur = 0;
            DebutManche = DateTime.Now;
        }
        #endregion
    }
}