using System;
using System.Windows.Forms;

namespace Novelity
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Try to load existing session
            bool hasSession = UserSession.LoadSession();

            if (hasSession && UserSession.IsLoggedIn)
            {
                // If we have a valid session, go directly to main form
                Application.Run(new Form1());
            }
            else
            {
                // Otherwise, show login form
                Application.Run(new Login());
            }
        }
    }
}