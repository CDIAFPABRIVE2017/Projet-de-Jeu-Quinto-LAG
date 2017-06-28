using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuintoLAG
{
    public class Jeux
    {
        private int _nbreManches;
        private int _nbreErreurMax;
        private TimeSpan _tempsMax;
        private bool _longeurMort;
        private bool _affichageLettre;

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

        public TimeSpan TempsMax
        {
            get
            {
                return _tempsMax;
            }

            set
            {
                _tempsMax = value;
            }
        }

        public bool LongeurMort
        {
            get
            {
                return _longeurMort;
            }

            set
            {
                _longeurMort = value;
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
    }
}
