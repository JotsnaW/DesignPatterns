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
                instance = new TransportByCar();
            }
            else if(m_transportType == "Truck")
            {
                instance = new TransportByTruck();
            }
            else
            {
                Console.WriteLine("Invalid transport type.");
            }
            return instance;
        }
    }
}
