namespace MultiLoggerWithSingleFile
{
    internal class Program
    {
        /// <summary>
        /// This Program is an example of Thread Safe Singleton - MultiLogger with single file.
        /// </summary>
        public static void Main()
        {
            string ErrorLogFile = "D:\\GitHub\\DesignPatterns\\SingletonDesignPatternExamples\\MultiLoggerWithSingleFile\\Error.log";

            Logger firstLoggerInstance = Logger.GetInstance();
            firstLoggerInstance.LogToFile("Error log1 - singleton pattern", ErrorLogFile);

            Logger secondLoggerInstance = Logger.GetInstance();
            secondLoggerInstance.LogToFile("Error log2 - singleton pattern", ErrorLogFile);

            Logger thirdLoggerInstance = Logger.GetInstance();
            thirdLoggerInstance.LogToFile("Error log3 - singleton pattern", ErrorLogFile);
            }
    }
}
