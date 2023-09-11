using TrackerLibrary;

namespace TrackerUI
{
    internal static class Program
    {
        //TODO - Configure the repository to the solution and not the specific project
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            //Initialize the database connections
            TrackerLibrary.GlobalConfig.InitializeConnections(DataBaseType.TextFile);

            Application.Run(new CreateTournamentForm());
            //test commit
        }
    }
}