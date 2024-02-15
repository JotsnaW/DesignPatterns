namespace MultiLoggerSingleton
{
    internal interface ILogger
    {
        void LogToFile(string logMessage, string m_logFile);
    }
}
