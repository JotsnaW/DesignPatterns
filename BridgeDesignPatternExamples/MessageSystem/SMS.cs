namespace MessageSystem
{
    public class SMS : IMessageType
    {
        private IMessageGateway m_messageType;

        public SMS(IMessageGateway messageType) 
        {
            m_messageType = messageType;
        }
        public void Send()
        {
            m_messageType.SendMessage("SMS");
        }
    }
}
