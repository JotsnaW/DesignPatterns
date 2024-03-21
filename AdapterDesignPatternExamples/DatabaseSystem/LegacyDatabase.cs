using System;

namespace DatabaseSystem
{
    internal class LegacyDatabase : ILegacyDatabase
    {
        public void LegacyConnect()
        {
            Console.WriteLine("Connecting to Legacy Database ...");
        }

        public void LegacyExecuteQuery(string query)
        {
            Console.Write(query);
        }
    }
}
