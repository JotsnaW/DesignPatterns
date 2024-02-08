using System;
using System.IO;

namespace MultiLoggerSingleton
{
    public class Logger
    {
        public static int count =0;
        private readonly string m_logFile;
        private readonly static Logger instance = new Logger();

        // private constructor
        private Logger() 
        { 

            m_logFile = "D:\\GitHub\\DesignPatterns\\MultiLoggerSingleton\\logFile.txt";
            count++;
        }

        // static method to get instance
        public static Logger GetInstance()
        {
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
