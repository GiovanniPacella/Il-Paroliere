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
            ApplicationConfiguration.Initialize();
            Application.Run(new Menu());
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.Sound);
            player.Play();

        }
    }
}