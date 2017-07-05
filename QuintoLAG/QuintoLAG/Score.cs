using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuintoLAG
{
    public class Score : IComparable<Score>
    {
        #region Champs
        private string _pseudo;
        private int _topScore;
        #endregion
        #region Propriétés
        public string Pseudo
        {
            get
            {
                return _pseudo;
            }

            set
            {
                _pseudo = value;
            }
        }
        public int TopScore
        {
            get
            {
                return _topScore;
            }

            set
            {
                _topScore = value;
            }
        }
        #endregion
        /// <summary>
        /// Compare one score with another
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Score other)
        {
            return TopScore.CompareTo(other.TopScore);
        }
        /// <summary>
        /// Return a score as a string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {

            return string.Format(@"Name : {0}  Score : {1}", this.Pseudo, this.TopScore);
        }
    }
}
