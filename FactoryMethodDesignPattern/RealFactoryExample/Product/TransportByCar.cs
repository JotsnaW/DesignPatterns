using System;

namespace RealFactoryExample
{
    public class TransportByCar : ITransport
    {
        public void Transport()
        {
            Console.WriteLine("Transport by Car.");
        }
    }
}
