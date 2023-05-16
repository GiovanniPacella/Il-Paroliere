using Il_Paroliere.Model;
using System.Reflection;

namespace Il_Paroliere
{
    internal static class MainController
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            MainModel x = new MainModel();
            x.creaBoard();
            x.stampaBoard();
            ApplicationConfiguration.Initialize();
            Application.Run(new Menu());

        }
    }
}