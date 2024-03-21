namespace DatabaseSystem
{
    internal class DatabaseAdapter : IModernDatabase
    {
        private readonly ILegacyDatabase m_legacyDatabase;

        public DatabaseAdapter(ILegacyDatabase legacyDatabase) 
        { 
            m_legacyDatabase = legacyDatabase;
        }

        public void ModernConnect()
        {
            m_legacyDatabase.LegacyConnect();
        }

        public void ModernExecuteQuery(string query)
        {
            m_legacyDatabase.LegacyExecuteQuery(query);
        }
    }
}
