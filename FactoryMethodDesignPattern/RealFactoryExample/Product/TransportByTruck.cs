using System;

namespace RealFactoryExample
{
    public class TransportByTruck : ITransport
    {
        public void Transport()
        {
            Console.WriteLine("Transport by Truck.");
        }
    }
}
