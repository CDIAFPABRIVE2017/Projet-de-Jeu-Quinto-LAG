using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuintoLAG
{
    public class Manche : Jeux
    {
        private Pioche _pioche;
        private int _nbreErreur;
        private TimeSpan _tempsEcoule;
        private int _score;

        internal Pioche Pioche
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
                return _tempsEcoule;
            }

            set
            {
                _tempsEcoule = value;
            }
        }

        public int Score
        {
            get
            {
                return _score;
            }

            set
            {
                _score = value;
            }
        }
    }
}
