using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuintoLAG
{
    public class Jeux : List<Manche>
    {
        #region Champs
        private int _nbreManches = Properties.Settings.Default.NbManches;
        private int _nbreErreurMax = Properties.Settings.Default.NbEssais;
        private bool _affichageLettre;
        #endregion
        #region Propriétés
        public int NbreManches
        {
            get
            {
                return _nbreManches;
            }

            set
            {
                _nbreManches = value;
            }
        }

        public int NbreErreurMax
        {
            get
            {
                return _nbreErreurMax;
            }

            set
            {
                _nbreErreurMax = value;
            }
        }
        public bool AffichageLettre
        {
            get
            {
                return _affichageLettre;
            }

            set
            {
                _affichageLettre = value;
            }
        }
        #endregion
        #region Constructeurs
        public Jeux()
        { }
        public Jeux(int nbreManches, int nbreErreurMax, bool affichageLettre)
        {
            NbreManches = nbreManches;
            NbreErreurMax = nbreErreurMax;
            AffichageLettre = affichageLettre;
        }
        #endregion
        #region Méthodes
        public void NouvellePArtie()
        {
            Dictionnaire dicoload = new Dictionnaire();
            Pioches pioches = new Pioches();
            dicoload.Load(@"E:\CDIAlexis\Projets Collaboratifs\Projet-de-Jeu-Quinto-LAG\QuintoLAG\test.csv");
            Pioche unePioche = new Pioche(dicoload.Random());
            pioches.Add(unePioche);

            foreach (Pioche item in pioches)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
        #endregion
    }
}
