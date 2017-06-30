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
        private string _pseudo;
        private int _topScore;

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

        public int CompareTo(Score other)
        {
            return TopScore.CompareTo(other.TopScore);
        }

        public override string ToString()
        {
            return string.Format(@"#{0} ; res.Name : {1}; res.Score : {2}", this.Pseudo, this.TopScore);
        }
    }
}
