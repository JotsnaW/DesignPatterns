using System;

namespace FactoryMethodDesignPattern
{
    public class TransportByTruck : ITransport
    {
        public void Transport()
        {
            Console.WriteLine("Transport by Truck.");
        }
    }
}
