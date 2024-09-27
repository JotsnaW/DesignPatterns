using System;

namespace MessageSystem
{
    public class WebService : IMessageGateway
    {
        public void SendMessage(string messageType)
        {
            Console.WriteLine($"Sending {messageType} using Web services.");
        }
    }
}
