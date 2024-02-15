using System;
using System.IO;

namespace MultiLoggerSingleton
{
    public class Logger: ILogger
    {
        private static Logger instance = null;
        private static readonly object lockobject  = new object();

        // private constructor
        private Logger() 
        { 
        }

        // static method to get instance
        public static Logger GetInstance()
        {
            lock (lockobject)
            {
                if (instance == null)
                {
                    instance = new Logger();
                }
            }
            return instance;
        }

        // method to log message to file
        public void LogToFile(string logMessage, string logFile)
        {
            Console.WriteLine($"Logging {logMessage} to file: {logFile}");
            File.AppendAllText(logFile, logMessage);
        }
    }
}
