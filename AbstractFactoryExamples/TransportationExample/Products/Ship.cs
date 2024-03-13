using System;

namespace TransportationExample
{
    public class Ship : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Deliver by Ship.");
        }
    }
}
