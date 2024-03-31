namespace MessageSystem
{
    public class Email : IMessageType
    {
        private IMessageGateway m_messagetype;
        public Email(IMessageGateway messagetype)
        {
            m_messagetype=messagetype;
        }
        public void Send()
        {
            m_messagetype.SendMessage("Email");
        }
    }
}
