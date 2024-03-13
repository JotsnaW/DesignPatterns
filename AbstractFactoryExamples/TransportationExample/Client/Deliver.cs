using System;

namespace TransportationExample.Client
{
    public class Deliver
    {
        public void Execute(ITransportFactory factory)
        {
            ITransport transport = factory.CreateTransport();
            if(transport != null)
            {
                transport.Deliver();
            }
            else
            {
                Console.WriteLine("Failed to Create Transport.");
            }
        }
    }
}
