using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuintoLAG
{
    public class Manche
    {
        #region Champs
        private Pioche _pioche;
        private int _nbreErreur;
        private int _score;
        private DateTime _debutManche;
        private DateTime _finManche;
        private TimeSpan _tempsEcoule;
        private TimeSpan _tempsManche;
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
                return _nbreErreur;
            }

            set
            {
                _nbreErreur = value;
            }
        }

        public TimeSpan TempsEcoule
        {
            get
            {
                return DateTime.Now - DebutManche;
            }
        }
        public int Score
        {
            get
            {
                return (int)TempsEcoule.TotalSeconds + 9 * NbreErreur; ;
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
        #endregion
        #region Constructeurs
        public Manche()
        { }
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