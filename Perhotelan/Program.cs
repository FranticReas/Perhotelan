namespace Perhotelan
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
            /*ApplicationConfiguration.Initialize();
            Application.Run(new frmLogin());*/
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Display the login form first
            using (var loginForm = new frmLogin())
            {
                // Show the login form as a dialog and check the result
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    // If login is successful (DialogResult.OK), run the MainMenu form
                    Application.Run(new frmMainMenu());
                }
                else
                {
                    // If login fails, exit the application
                    Application.Exit();
                }
            }
        }
    }
}