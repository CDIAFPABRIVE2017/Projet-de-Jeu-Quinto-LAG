using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuintoLAG
{
    [Serializable]
    public class Pioches : HashSet<Pioche>
    {

        public Pioches()
        { }


        /// <summary>
        /// Ajouter une Pioche
        /// </summary>
        /// <param name="pioche"></param>
        new public void Add(Pioche pioche)
        {
            if (!this.Contains(pioche))
            { base.Add(pioche); }
        }
        /// <summary>
        /// Ajout une liste de Pioches
        /// </summary>
        /// <param name="pioches">Tout type implémentant IEnumerable</param>
        public void AddRange(IEnumerable<Pioche> pioches)
        {
            foreach (Pioche item in pioches)
            {
                this.Add(item);
            }
        }


    }
}
