using System;

namespace FactoryMethodDesignPattern
{
    public class AirTransport : ITransport
    {
        public void Transport()
        {
            Console.WriteLine("Transport by Air.");
        }
    }
}
