using System;

namespace RealFactoryExample
{
    public class AirTransport : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Transport by Air.");
        }
    }
}
