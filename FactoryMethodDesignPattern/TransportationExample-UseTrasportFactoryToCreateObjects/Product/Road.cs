using System;

namespace FactoryMethodDesignPattern
{
    public class Road : ITransport
    {
        public void Transport()
        {
            Console.WriteLine("Transport by Road.");
        }
    }
}
