using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnrealLibraryApp.Lib;
using System.IO;

// TO DO
// + try/catch on writing/reading files
// + graphs
// + stats
// - module tests
// + fileChanged flag 

namespace UnrealLibraryApp
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

    }
}
