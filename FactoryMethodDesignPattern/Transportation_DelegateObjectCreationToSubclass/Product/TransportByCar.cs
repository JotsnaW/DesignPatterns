using System;

namespace FactoryMethodDesignPattern
{
    public class TransportByCar : ITransport
    {
        public void Transport()
        {
            Console.WriteLine("Transport by Car.");
        }
    }
}
