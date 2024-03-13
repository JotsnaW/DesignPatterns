using System;

namespace TransportationExample
{
    public class TransportByShip : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Deliver by Ship.");
        }
    }
}
