using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WFQuinto
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           
            MonApplication.Dictionnaire.Load(Properties.Settings.Default.AppData);
            if (MonApplication.Dictionnaire.Count<50)
            {

            }
            Application.Run(new MenuPrincipal());
            ////test chrono
            //Stopwatch watch = new Stopwatch();
        }
    }
}
