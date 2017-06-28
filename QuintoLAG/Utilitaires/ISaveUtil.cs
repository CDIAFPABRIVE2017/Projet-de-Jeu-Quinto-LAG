using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Utilitaires
{
    /// <summary>
    /// Interface définissant les comportements à implémenter 
    /// pour sauvegarder et charger des données
    /// </summary>
    public interface ISauvegarde
    {
        void Save(string pathRepData, IEnumerable objetASauvegarder);
        IEnumerable Load(string pathRepData, Type typeACharger);
    }
}
