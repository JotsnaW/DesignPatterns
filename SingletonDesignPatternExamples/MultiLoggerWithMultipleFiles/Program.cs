namespace MultiLoggerWithMultipleFiles
{
    internal class Program
    {
        /// <summary>
        /// This Program is an example of Thread Safe Singleton - MultiLogger with different files.
        /// </summary>
        static void Main()
        {
            string DatabaseLogFile = "D:\\GitHub\\DesignPatterns\\SingletonDesignPatternExamples\\MultiLoggerWithMultipleFiles\\Database.log";
            string ErrorLogFile = "D:\\GitHub\\DesignPatterns\\SingletonDesignPatternExamples\\MultiLoggerWithMultipleFiles\\Error.log";


            Logger firstLoggerObject = Logger.GetLoggerInstance(DatabaseLogFile);
            firstLoggerObject.LogToFile(DatabaseLogFile, "Database Log entry");

            Logger secondLoggerObject = Logger.GetLoggerInstance(ErrorLogFile);
            secondLoggerObject.LogToFile(ErrorLogFile, "Error Log entry");

            Logger thirdLoggerObject = Logger.GetLoggerInstance(DatabaseLogFile);
            thirdLoggerObject.LogToFile(DatabaseLogFile, "Database Log entry");

            Logger fourthLoggerObject = Logger.GetLoggerInstance(DatabaseLogFile);
            fourthLoggerObject.LogToFile(DatabaseLogFile, "Database Log entry");

            Logger fifthLoggerObject = Logger.GetLoggerInstance(ErrorLogFile);
            fifthLoggerObject.LogToFile(ErrorLogFile, "Error Log entry."); 
        }
    }
}
