using System;

namespace TransportationExample
{
    internal class Truck : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Deliver by Truck.");
        }
    }
}
