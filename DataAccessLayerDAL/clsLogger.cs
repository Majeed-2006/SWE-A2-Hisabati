using System;
using System.IO;

namespace DataAccessLayerDAL
{
    public static class clsLogger
    {
       
        private static string _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ErrorLog.txt");

        public static void LogError(Exception ex)
        {
            try
            {
                
                string errorMessage = $"--- [{DateTime.Now}] ---\n" +
                                     $"Message: {ex.Message}\n" +
                                     $"StackTrace: {ex.StackTrace}\n" +
                                     "--------------------------------------------------\n";

             
                File.AppendAllText(_filePath, errorMessage);
            }
            catch
            {
               
            }
        }
    }
}