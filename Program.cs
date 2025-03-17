namespace DHEA_CHARISSED_BARTE_GUI { 
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
            DHEA_CHARISSED_BARTE_GUI.ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
        }
    }
}