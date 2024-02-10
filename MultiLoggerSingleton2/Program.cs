using System;

namespace MultiLoggerSingleton2
{
    internal class Program
    {
        /// <summary>
        /// This Program is an example of Thread Safe Singleton - MultiLogger with different files.
        /// </summary>
        static void Main()
        {
            string fileName1 = "D:\\GitHub\\DesignPatterns\\MultiLoggerSingleton\\log1.text";
            string fileName2 = "D:\\GitHub\\DesignPatterns\\MultiLoggerSingleton\\log2.text";


            Logger log1 = Logger.GetInstance(fileName1);
            log1.LogToFile(fileName1, "test1");

            Logger log2 = Logger.GetInstance(fileName2);
            log2.LogToFile(fileName2, "test2");

            Logger log3 = Logger.GetInstance(fileName1);
            log3.LogToFile(fileName1, "test3");

            Logger log4 = Logger.GetInstance(fileName1);
            log4.LogToFile(fileName1, "test4");

            Logger log5 = Logger.GetInstance(fileName2);
            log5.LogToFile(fileName2, "test5"); 

            Console.WriteLine($"Constructor is called for {Logger.m_count} time.");
            Console.ReadKey();
        }
    }
}
