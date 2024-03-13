using System;

namespace TransportationExample
{
    public class RoadTransportFactory : ITransportFactory
    {
        private string m_transportType;
        

        public RoadTransportFactory(string transportType)
        {
            this.m_transportType = transportType;
        }
        public ITransport CreateTransport()
        {
            ITransport instance = null;
            if (m_transportType == "Car")
            {
                instance = new Car();
            }
            else if(m_transportType == "Truck")
            {
                instance = new Truck();
            }
            else
            {
                Console.WriteLine("Invalid transport type.");
            }
            return instance;
        }
    }
}
