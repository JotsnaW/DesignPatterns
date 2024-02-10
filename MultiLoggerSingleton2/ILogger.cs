namespace MultiLoggerSingleton2
{
    public interface ILogger
    {
        void LogToFile(string fileName, string logMessage);
    }
}
