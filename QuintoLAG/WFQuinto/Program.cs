﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Xml.Serialization;
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
            MonApplication.Dictionnaire.LoadTriage(Properties.Settings.Default.AppData+ "\\liste_francais.csv");
            MonApplication.Highscores.LoadScores();
            Application.Run(new MenuPrincipal());
           
        }
    }
}
