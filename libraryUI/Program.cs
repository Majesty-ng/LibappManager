using libmanagerLibrary;

namespace libraryUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.


            //
            libmanagerLibrary.GlobalConfig.Initializeconnections(databaseType.TextFile);
            ApplicationConfiguration.Initialize();
            Application.Run(new userdashboard());
            //Application.Run(new loginForm());
        }
    }
}