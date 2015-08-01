using GameReViews.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GameReViews
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Model.Document.GetInstance().Load(new MockModelPersister());

            Model.Document.GetInstance().Autentica("utente1", "password1");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
