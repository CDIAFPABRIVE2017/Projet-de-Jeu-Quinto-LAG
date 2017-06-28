using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Xml;

namespace QuintoLAG
{
    [Serializable()]
    public class Dictionnaire : HashSet<EntreDictoinnaire>
    {

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Dictionnaire()
        {

        }

    }


    public class EntreDictoinnaire
    {


        private string _entre;
        private string _definition;

        /// <summary>
        /// Contrusteur par défaut
        /// </summary>
        public EntreDictoinnaire()
        {

        }


        public string Entre
        {
            get
            {
                return _entre;
            }

            set
            {
                _entre = value;
            }
        }

        public string Definition
        {
            get
            {
                return _definition;
            }

            set
            {
                _definition = value;
            }
        }
    }
}
