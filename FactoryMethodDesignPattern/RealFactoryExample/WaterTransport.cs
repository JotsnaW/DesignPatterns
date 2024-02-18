using System;

namespace RealFactoryExample
{
    public class WaterTransport : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Transport by Water.");
        }
    }
}
