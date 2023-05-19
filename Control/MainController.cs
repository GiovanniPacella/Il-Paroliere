using Il_Paroliere.Model;
using System.Reflection;

namespace Il_Paroliere
{
    internal class MainController
    {
        private static string nicknameGiocatore;
        private static int numParole; 
        private static int difficolta;
        private static int punteggio; 

        public void setNicknameGiocatore(string nickname)
        {
            nicknameGiocatore = nickname;
        }
        public string getNicknameGiocatore()
        {
            return nicknameGiocatore;
        }
        public void setDifficolta(int dif)
        {
            difficolta = dif;
        }
        public int getDifficolta()
        {
            return difficolta;
        }
        public void setPunteggio(int p)
        {
            punteggio = p;
        }
        public int getPunteggio()
        {
            return punteggio;
        }
        public void setNumParole(int numPar)
        {
            numParole = numPar;
        }
        public int getNumParole()
        {
            return numParole;
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