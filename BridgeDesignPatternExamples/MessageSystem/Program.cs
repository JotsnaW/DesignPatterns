using System;

namespace MessageSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMessageType sms = new SMS(new WebService());
            sms.Send();

            IMessageType email = new Email(new ThirdPartyAPI());
            email.Send();
        }
    }
}
