using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Globalization;
using Utilitaires;

namespace QuintoLAG
{
    [Serializable()]
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
