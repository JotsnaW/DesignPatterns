using System;

namespace FactoryMethodDesignPattern
{
    public class Water : ITransport
    {
        public void Transport()
        {
            Console.WriteLine("Transport by Water.");
        }
    }
}
