using System;

namespace MessageSystem
{
    public class ThirdPartyAPI : IMessageGateway
    {
        public void SendMessage(string messageType)
        {
            Console.WriteLine($"Sending {messageType} using Third Party API.");
        }
    }
}
