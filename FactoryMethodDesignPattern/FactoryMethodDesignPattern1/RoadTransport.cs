using System;

namespace FactoryMethodDesignPattern
{
    public class RoadTransport : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Transport by Road.");
        }
    }
}
