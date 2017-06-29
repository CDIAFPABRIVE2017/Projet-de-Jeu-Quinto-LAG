using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitaires;

namespace QuintoLAG
{
    [Serializable()]
    public class Scores: HashSet<Score>
    {


        public Scores()
        {

        }

        public void Save(ISauvegarde sauvegarde, string pathRepData)
        {
            sauvegarde.Save(pathRepData, this);
        }

        public void Load(ISauvegarde sauvegarde, string pathRepData)
        {
            this.SymmetricExceptWith((Scores)sauvegarde.Load(pathRepData, this.GetType()));
        }

    }
}
