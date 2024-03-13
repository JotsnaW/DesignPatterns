using System;

namespace TransportationExample
{
    public class TransportByFerry : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Deliver by Ferry.");
        }
    }
}
