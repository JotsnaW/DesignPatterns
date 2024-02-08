using System;

namespace MultiLoggerSingleton
{
    internal class Program
    {
        // This Program is example of Thread Safe Singleton
        static void Main()
        {
            Logger logger1 = Logger.GetInstance();
            logger1.LogToFile("log1- singleton pattern" + Environment.NewLine);

            Logger logger2 = Logger.GetInstance();
            logger2.LogToFile("log2- singleton pattern" + Environment.NewLine);

            Logger logger3 = Logger.GetInstance();
            logger3.LogToFile("log3- singleton pattern" + Environment.NewLine);
        }
    }
}
