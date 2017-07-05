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
    public class Scores : List<Score>, ICollectionMetier
    {
        ISauvegarde serialiseur = new SauvegardeXML();
        // ISauvegarde deserialiseur = new SauvegardeXML();



        int tailleLeaderboard = 10;

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

        /// <summary>
        /// charge le contenu du fichier scores
        /// </summary>
        public void LoadScores()
        {

            this.Load(serialiseur, Properties.Settings.Default.AppData);
        }

        /// <summary>
        /// Reinitialise le leaderboard et la sauvegarde XML
        /// </summary>
        public void ResetScores()
        {

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

        /// <summary>
        /// Ajoute un score a la liste
        /// </summary>
        /// <param name="score"></param>
        new public void Add(Score score)
        {
            base.Add(score);
            this.Sort();
            if (this.Count > TailleLeaderboard)
                this.RemoveRange(tailleLeaderboard, this.Count - TailleLeaderboard);
            this.Save(serialiseur, Properties.Settings.Default.AppData);
        }

        /// <summary>
        /// Transforme tout les scores en chaines
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string leaderboard = "";
            foreach (Score item in this)
            {
                leaderboard += string.Format("({0})  {1}  \r\n", IndexOf(item) + 1, item);
            }
            return leaderboard;
        }
        /// <summary>
        /// génère un score et l'ajoute a la liste
        /// </summary>
        /// <param name="pseudo"></param>
        /// <param name="scoreMoyenne"></param>
        public void addLeaderBoard(string pseudo, int scoreMoyenne)
        {
            Score scorepartie = new Score() { TopScore = scoreMoyenne };
            scorepartie.Pseudo = pseudo;
            this.Add(scorepartie);
        }

        /// <summary>
        /// vérifie l'éligibilité d'un score par rapport au tableau des scores
        /// </summary>
        /// <param name="scoreMoyenne"></param>
        /// <returns></returns>
        public bool IsLeaderBoard(int scoreMoyenne)
        {
            //this.LoadScores();
            Score scorepartie = new Score() { TopScore = scoreMoyenne };
            if (this.Count < this.TailleLeaderboard)
            { return true; }
            if (scorepartie.CompareTo(this[this.Count - 1]) < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// Sauvegarde les scores
        /// </summary>
        /// <param name="sauvegarde"></param>
        /// <param name="pathRepData"></param>
        public void Save(ISauvegarde sauvegarde, string pathRepData)
        {
            sauvegarde.Save(pathRepData, this);
        }

        /// <summary>
        /// Charge les scores
        /// </summary>
        /// <param name="sauvegarde"></param>
        /// <param name="pathRepData"></param>
        public void Load(ISauvegarde sauvegarde, string pathRepData)
        {
            try
            {
                this.AddRange((Scores)sauvegarde.Load(pathRepData, this.GetType()));
            }
            catch
            {

            }
            //  this.sauvegarde.Load(pathRepData, this.GetType());
        }


    }
}
