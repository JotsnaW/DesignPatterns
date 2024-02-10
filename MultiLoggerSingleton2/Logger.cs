using System;
using System.Collections.Generic;
using System.IO;

namespace MultiLoggerSingleton2
{
    public class Logger: ILogger
    {
        public static int m_count = 0;
        private static readonly object lockObject = new object();
        private static Dictionary<string, Logger> m_object = new Dictionary<string, Logger>();

        // private constructor
        private Logger()
        {
            m_count++;
        }

        // static method to get instance
        public static Logger GetInstance(string fileName)
        {
            lock (lockObject)
            {
                if (!m_object.ContainsKey(fileName))
                {
                    m_object.Add(fileName, new Logger());
                }
            }
            m_object.TryGetValue(fileName, out Logger instance);
            return instance;
        }

        public void LogToFile(string fileName, string logMessage)
        {
            lock (lockObject) 
            {
                Console.WriteLine($"Logging {logMessage} to file: {fileName}");
                File.AppendAllText(fileName, logMessage);
            }
        }
    }
}
