using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitaires;

namespace QuintoLAG
{
    [Serializable]
    public class EntreeDictionnaire
    {
        private string _entree;
        private string _definition;

        public string Entree
        {
            get
            {
                return _entree;
            }

            set
            {
                _entree = value;
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
        public EntreeDictionnaire()
        { }
    }
}
