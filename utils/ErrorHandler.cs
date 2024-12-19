using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacultySystem_3Y_DB.utils
{
    internal class ErrorHandler
    {
        /// <summary>
        /// Logs exception details to a file.
        /// </summary>
        public static void LogError(Exception ex)
        {
            try
            {
                
                
                    Console.WriteLine("------ Exception Details ------");
                Console.WriteLine($"Timestamp: {DateTime.Now}");
                    Console.WriteLine($"Message: {ex.Message}");
                    Console.WriteLine($"StackTrace: {ex.StackTrace}");
                    Console.WriteLine($"InnerException: {ex.InnerException?.Message}");
                    Console.WriteLine("--------------------------------\n");
                
            }
            catch
            {
                // If logging fails, silently ignore (don't crash the app).
            }
        }

        /// <summary>
        /// Displays a user-friendly error message.
        /// </summary>
        public static void ShowFriendlyError(string customMessage)
        {
            MessageBox.Show(customMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Handles exceptions centrally.
        /// </summary>
        public static void HandleException(Exception ex, string customMessage = "An unexpected error occurred. Please try again.")
        {
            LogError(ex);
            ShowFriendlyError(customMessage);
        }
    }
}
    

