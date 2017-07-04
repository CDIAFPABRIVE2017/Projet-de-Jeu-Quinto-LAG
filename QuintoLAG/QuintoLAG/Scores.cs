using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitaires;
using System.IO;


namespace QuintoLAG
{
    [Serializable]
   // public class Scores: List<Score> 
   public class Scores: List<Score>, ICollectionMetier
    {
        ISauvegarde serialiseur = new SauvegardeXML();
       // ISauvegarde deserialiseur = new SauvegardeXML();
        

        
        int tailleLeaderboard =10;

        public int TailleLeaderboard
        {
            get
            {
                return tailleLeaderboard;
            }
        }

        public Scores()
        {
         

        }

        public void LoadScores()
        {
           
            this.Load(serialiseur, Properties.Settings.Default.AppData);
        }

        /// <summary>
        /// Reinitialise le leaderboard et la sauvegarde XML
        /// </summary>
        public void ResetScores()
        {
            //moyennement testé
            if (this.Count != 0)
            {
                this.RemoveRange(0, TailleLeaderboard - 1);
                this.Save(serialiseur, Properties.Settings.Default.AppData);
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        new public void Add(Score score)
        {
            base.Add(score);
            this.Sort();
            if (this.Count > TailleLeaderboard)
                this.RemoveAt(this.Count - 1);
            this.Save(serialiseur, Properties.Settings.Default.AppData);
        }

        public override string ToString()
        {
            string leaderboard = "";
            foreach (Score item in this)
            {
                leaderboard += string.Format("({0})  {1}  \r\n", IndexOf(item) + 1, item);
            }
            return leaderboard;
        }
        public void addLeaderBoard(string pseudo, int scoreMoyenne)
        {
            Score scorepartie = new Score() { TopScore = scoreMoyenne };
            this.Add(scorepartie);
            if ((scorepartie.CompareTo(this[this.Count - 1]) < 0) || (this.Count < this.TailleLeaderboard))
            {
                scorepartie.Pseudo = pseudo;
            }
        }
        public bool IsLeaderBoard(int scoreMoyenne)
        {
            this.LoadScores();
            Score scorepartie = new Score() { TopScore = scoreMoyenne };
            if ((scorepartie.CompareTo(this[this.Count - 1]) < 0) || (this.Count < this.TailleLeaderboard))
                return true;
            return false;
        }

        public void Save(ISauvegarde sauvegarde, string pathRepData)
        {
            sauvegarde.Save(pathRepData, this);
        }

        public void Load(ISauvegarde sauvegarde, string pathRepData)
        {
            this.AddRange((Scores)sauvegarde.Load(pathRepData, this.GetType()));
          //  this.sauvegarde.Load(pathRepData, this.GetType());
        }


    }
}
