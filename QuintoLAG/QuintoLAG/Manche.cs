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
        private int _scoreManche;
        private DateTime _debutManche;
        private DateTime _finManche;
        private TimeSpan _tempsManche;
        private bool _mancheGagne;
        private bool _mancheTermine;

        bool passageFM = true;

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
        public int ScoreManche
        {
            get
            {
                return (((int)TempsManche.TotalSeconds * this.PointParSeconde) + (this.PointParErreur * NbreErreur));
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
                if (MancheTermine)
                {
                    return _finManche;
                }
                return DateTime.Now;
            }
            set
            {
                if (passageFM)
                {
                    _finManche = value;
                    passageFM = false;
                }
            }
        }
        public TimeSpan TempsManche
        {
            get
            {
                return FinManche - DebutManche;
            }
        }
        public bool MancheTermine
        {
            get
            {
                if (NbreErreur >= this.NbreErreurMax || Pioche.MotTrouve())
                {
                    return true;
                }
                return false;
            }
        }
        public bool MancheGagne
        {
            get
            {
                if (Pioche.MotTrouve() && MancheTermine)
                {
                    return true;
                }
                return false;
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
        public Manche(Pioche pioche, int nbreManches, int nbreErreurMax, int pointParSeconde, int pointParErreur)
        {
            Pioche = pioche;
            NbreErreur = 0;
            DebutManche = DateTime.Now;
            NbreManches = nbreManches;
            NbreErreurMax = nbreErreurMax;
            PointParSeconde = pointParSeconde;
            PointParErreur = pointParErreur;
        }
        #endregion
    }
}