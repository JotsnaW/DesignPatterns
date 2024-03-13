using System;

namespace TransportationExample
{
    internal class TransportByCar: ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Deliver by Car.");
        }
    }
}
