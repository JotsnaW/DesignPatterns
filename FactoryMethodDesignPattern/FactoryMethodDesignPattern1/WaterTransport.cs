using System;

namespace FactoryMethodDesignPattern
{
    public class WaterTransport : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Transport by Water.");
        }
    }
}
