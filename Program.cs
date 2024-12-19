using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacultySystem_3Y_DB.Resources.utils;
namespace FacultySystem_3Y_DB
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.ThreadException += new ThreadExceptionEventHandler(GlobalThreadExceptionHandler);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(GlobalUnhandledExceptionHandler);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new Form1());
        }

        private static void GlobalThreadExceptionHandler(object sender,ThreadExceptionEventArgs e)
        {
            ErrorHandler.HandleException(e.Exception, "An application error has occurred. Please restart the application.");
        }

        private static void GlobalUnhandledExceptionHandler(object sender, UnhandledExceptionEventArgs e)
        {
            Exception ex = e.ExceptionObject as Exception;
            if (ex != null)
            {
                ErrorHandler.HandleException(ex, "A critical error has occurred. Please contact support.");
            }
        }
    }
}
