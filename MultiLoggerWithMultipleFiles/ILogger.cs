namespace MultiLoggerWithMultipleFiles
{
    public interface ILogger
    {
        void LogToFile(string fileName, string logMessage);
    }
}
