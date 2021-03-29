using PostSharp.Patterns.Diagnostics;
using PostSharp.Patterns.Diagnostics.Backends.Trace;
using System;
using System.Windows.Forms;

namespace DoIt
{
    /// <summary>
    /// Applicaiton-wide code.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoggingServices.DefaultBackend = new TraceLoggingBackend();

            Application.Run(MainWindow.Instance);
        }
    }
}