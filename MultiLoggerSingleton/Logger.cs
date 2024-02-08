using System;
using System.IO;

namespace MultiLoggerSingleton
{
    public class Logger
    {
        public static int m_count = 0;
        private readonly string m_logFile;
        private static Logger instance = null;
        private static readonly object lockobject  = new object();

        // private constructor
        private Logger() 
        { 
            m_count++;
            Console.WriteLine($"Constructor is called for {m_count} time.");
            m_logFile = "D:\\GitHub\\DesignPatterns\\MultiLoggerSingleton\\logFile.txt";
        }

        // static method to get instance
        public static Logger GetInstance()
        {
            if(instance == null)
            {
                lock (lockobject)
                {
                    if (instance == null)
                    {
                        instance = new Logger();
                    }
                }  
            }
            return instance;
        } 

        // method to log message to file
        public void LogToFile(string logMessage)
        {
            Console.WriteLine($"Logging {logMessage} to file: {m_logFile}");
            File.AppendAllText(m_logFile, logMessage);
        }
    }
}
