using System;

namespace TransportationExample
{
    internal class TransportByTruck : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Deliver by Truck.");
        }
    }
}
