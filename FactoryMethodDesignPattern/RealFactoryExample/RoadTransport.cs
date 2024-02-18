using System;

namespace RealFactoryExample
{
    public class RoadTransport : ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Transport by Road.");
        }
    }
}
