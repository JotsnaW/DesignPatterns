using System;

namespace TransportationExample
{
    internal class Car: ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Deliver by Car.");
        }
    }
}
