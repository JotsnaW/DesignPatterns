using System;

namespace MultiLoggerSingleton
{
    internal class Program
    {
        static void Main()
        {

            Logger logger1 = Logger.GetInstance();
            logger1.LogToFile("log1- singleton pattern" + Environment.NewLine);

            Logger logger2 = Logger.GetInstance();
            logger2.LogToFile("log2- singleton pattern" + Environment.NewLine);

            Logger logger3 = Logger.GetInstance();
            logger3.LogToFile("log3- singleton pattern" + Environment.NewLine);

            Console.WriteLine($"Constructor is called for {Logger.count} times.");
        }
    }
}
