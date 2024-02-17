using System;

namespace FactoryMethodDesignPattern
{
    public class AirTransport : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Transport by Air.");
        }
    }
}
