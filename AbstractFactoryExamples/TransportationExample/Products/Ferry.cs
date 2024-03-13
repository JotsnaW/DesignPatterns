using System;

namespace TransportationExample
{
    public class Ferry : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Deliver by Ferry.");
        }
    }
}
