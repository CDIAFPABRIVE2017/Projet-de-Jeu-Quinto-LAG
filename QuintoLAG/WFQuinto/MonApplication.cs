using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuintoLAG;

namespace WFQuinto
{
    public static class MonApplication
    {
        static Dictionnaire _dictionnaire = new Dictionnaire();
        static Scores _highscores = new Scores();
        public static Dictionnaire Dictionnaire
        {
            get
            {
                return _dictionnaire;
            }
        }

        public static Scores Highscores
        {
            get
            {
                return _highscores;
            }
        }
    }
}
