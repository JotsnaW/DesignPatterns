namespace DatabaseSystem
{
    public interface ILegacyDatabase
    {
        void LegacyConnect();
        void LegacyExecuteQuery(string query);
    }
}
