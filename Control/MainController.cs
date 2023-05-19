using Il_Paroliere.Model;
using System.Reflection;

namespace Il_Paroliere
{
    internal class MainController
    {
        private static string nicknameGiocatore;

        public void setNicknameGiocatore(string nickname)
        {
            nicknameGiocatore = nickname;
        }
        public string getNicknameGiocatore()
        {
            return nicknameGiocatore;
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Menu());

        }
    }
}