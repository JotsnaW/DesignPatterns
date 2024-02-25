using System;

namespace FactoryMethodDesignPattern
{
    public class WaterTransport : ITransport
    {
        public void Transport()
        {
            Console.WriteLine("Transport by Water.");
        }
    }
}
