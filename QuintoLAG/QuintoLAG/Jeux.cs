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
        private int _nbreManches;
        private int _nbreErreurMax;
        private int _pointParSeconde;
        private int _pointParErreur;
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

        public int PointParSeconde
        {
            get
            {
                return _pointParSeconde;
            }
            set
            {
                _pointParSeconde = value;
            }
        }

        public int PointParErreur
        {
            get
            {
                return _pointParErreur;
            }
            set
            {
                _pointParErreur = value;
            }
        }
        #endregion
        #region Constructeurs
        public Jeux()
        { }
        public Jeux(int nbreManches, int nbreErreurMax, int pointParSeconde, int pointParErreur)
        {
            NbreManches = nbreManches;
            NbreErreurMax = nbreErreurMax;
            PointParSeconde = pointParSeconde;
            PointParErreur = pointParErreur;
        }
        #endregion
    }
}
