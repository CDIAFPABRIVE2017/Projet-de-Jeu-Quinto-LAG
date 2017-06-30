using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitaires;

namespace QuintoLAG
{
    [Serializable()]
   // public class Scores: List<Score> 
   public class Scores: List<Score>
    {

        int tailleLeaderboard =10;

        public Scores()
        {

        }

        new public void Add(Score score)
        {

            base.Add(score);
            this.Sort();
            if (this.Count > tailleLeaderboard)
                this.RemoveAt(this.Count-1);       

        }

        public override string ToString()
        {
            string leaderboard ="";
            foreach (Score item in this)
            {
                leaderboard += string.Format("#{0}  {1}  \n",IndexOf(item)+1, item);
            }
            return leaderboard;
        }

        public void Save(ISauvegarde sauvegarde, string pathRepData)
        {
            sauvegarde.Save(pathRepData, this);
        }

        public void Load(ISauvegarde sauvegarde, string pathRepData)
        {
            //this.SymmetricExceptWith((Scores)sauvegarde.Load(pathRepData, this.GetType()));
            sauvegarde.Load(pathRepData, this.GetType());
        }


    }
}
