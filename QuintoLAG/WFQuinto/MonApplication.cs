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

        public static Dictionnaire Dictionnaire
        {
            get
            {
                return _dictionnaire;
            }
        }
    }
}
