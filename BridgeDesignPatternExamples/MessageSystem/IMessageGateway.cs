namespace MessageSystem
{
    public interface IMessageGateway
    {
        void SendMessage(string messageType);
    }
}
