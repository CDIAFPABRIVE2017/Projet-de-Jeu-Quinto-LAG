using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.IO;
using System.Collections;

namespace Utilitaires
{
    class SerialiseurTEXTE : ISauvegarde
    {
        public void Save(string pathRepData, IEnumerable objetASauvegarder)
        {
            Type type = objetASauvegarder.GetType();

            string pathCsvDocument = string.Format("{0}\\{1}.csv", pathRepData, type.FullName);
            using (FileStream fs = new FileStream(pathCsvDocument, FileMode.Create, FileAccess.Write, FileShare.Read))
            {

                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine();
                sw.Close();
                fs.Close();
            }
        }
        public IEnumerable Load(string pathRepData, Type typeACharger)
        {
            Object objet = null;

            string pathXmlDocument = string.Format("{0}\\{1}.csv", pathRepData, typeACharger.FullName);
            using (FileStream fs = new FileStream(pathXmlDocument, FileMode.Open, FileAccess.Read, FileShare.Read))
            {

                StreamReader sr = new StreamReader(fs);
                objet = sr.ReadLine();

                sr.Close();
                fs.Close();
            }

            return objet as IEnumerable;
        }
    }
}
