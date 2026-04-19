using System;
using System.Windows.Forms;

namespace SimplyRugby_System
{
    /// <summary>
    /// Contains the static entry point for the Simply Rugby management application.
    /// </summary>
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// Configures visual styles and initializes the login security gate.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}