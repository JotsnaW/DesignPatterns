using System;

namespace FactoryMethodDesignPattern
{
    public class SeaTransport : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Transport by Sea.");
        }
    }
}
