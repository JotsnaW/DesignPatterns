namespace DatabaseSystem
{
    public interface IModernDatabase
    {
        void ModernConnect();
        void ModernExecuteQuery(string query);
    }
}
