namespace messages
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static MainForm mainForm = new MainForm();
        public static AuthorizationForm authorizationForm = new AuthorizationForm();
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(authorizationForm);
        }
    }
}