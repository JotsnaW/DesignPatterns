using System;

namespace FactoryMethodDesignPattern
{
    public class RoadTransport : ITransport
    {
        public void Transport()
        {
            Console.WriteLine("Transport by Road.");
        }
    }
}
