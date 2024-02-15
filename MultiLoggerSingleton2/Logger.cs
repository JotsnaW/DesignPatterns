using System;
using System.Collections.Generic;
using System.IO;

namespace MultiLoggerSingleton2
{
    public class Logger: ILogger
    {
        private static readonly object lockObject = new object();
        private static readonly Dictionary<string, Logger> m_objects = new Dictionary<string, Logger>();

        // private constructor
        private Logger()
        {
        }

        // static method to get instance
        public static Logger GetLoggerInstance (string LogFileName)
        {
            lock ( lockObject )
                {
                if ( !m_objects.TryGetValue(LogFileName, out Logger instance) )
                    {
                    m_objects.Add(LogFileName, instance = new Logger());
                    }
                return instance;
                }
            }

        public void LogToFile(string LogFileName, string logMessage)
        {
            lock (lockObject) 
            {
                Console.WriteLine($"Logging - {logMessage} to file: {LogFileName}");
                File.AppendAllText(LogFileName, logMessage);
            }
        }
    }
}
