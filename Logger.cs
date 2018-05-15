using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    
    public class Logger
    {
        const string DEFAULT_LOG_FILE_PATH = "application.log";

        public static string Log(string text, DateTime date, string filePath)
        {
            string message = $"{date.ToShortDateString()} - {date.ToLongTimeString()} - {text}";
            WriteMessage(message, filePath);
            return message;
        }

        public static void Log(string text, string filePath)
        {
            Log(text, DateTime.Now, filePath);
        }

        public static void Log(string text, DateTime date)
        {
            Log(text, date, DEFAULT_LOG_FILE_PATH);
        }

        public static void Log(string text)
        {
            Log(text, DateTime.Now);
        }

        private static void WriteMessage(string Message, string filePath)
        {
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine(Message);
            }
        }
    }
}
