using System;

namespace FactoryMethodDesignPattern
{
    public class TransportByTempo : ITransport
    {
        public void Transport()
        {
            Console.WriteLine("Transport by Tempo.");
        }
    }
}
