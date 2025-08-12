using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoTransactionLogger
{
    public class Logger : ILogger
    {
        public readonly string LogFilePath;
        public Logger(string logFilePath)
        {
            LogFilePath = logFilePath;
        }
        public void AppendToFile(string line)
        {
            try
            {
                File.AppendAllText(LogFilePath, line + Environment.NewLine);
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred while writing to the file: {ex.Message}");
            }

        }
        public void Log(string message)
        {
            string logEntry = $"{DateTime.Now} - {message}";
            AppendToFile(logEntry);
        }
    }
}
