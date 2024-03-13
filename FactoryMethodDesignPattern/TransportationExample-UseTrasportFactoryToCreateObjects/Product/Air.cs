using System;

namespace FactoryMethodDesignPattern
{
    public class Air : ITransport
    {
        public void Transport()
        {
            Console.WriteLine("Transport by Air.");
        }
    }
}
