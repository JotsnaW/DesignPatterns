namespace DatabaseSystem
{
    internal class Program
    {
        public static void Main()
        {
            ILegacyDatabase legacyDatabase = new LegacyDatabase();
            IModernDatabase modernDatabase = new DatabaseAdapter(legacyDatabase);
            modernDatabase.ModernConnect();

            modernDatabase.ModernExecuteQuery("select * from table");
        }
    }
}
