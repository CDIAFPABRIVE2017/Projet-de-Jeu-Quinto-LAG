using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuintoLAG
{
    public class Score
    {
        private string _pseudo;
        private int _rang;
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

        public int Rang
        {
            get
            {
                return _rang;
            }

            set
            {
                _rang = value;
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
    }
}
