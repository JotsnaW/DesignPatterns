using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLoggerSingleton
{
    internal interface ILogger
    {
        void LogToFile(string logMessage);
    }
}
