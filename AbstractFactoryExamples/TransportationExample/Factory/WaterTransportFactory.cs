using System;

namespace TransportationExample
{
    public class WaterTransportFactory : ITransportFactory
    {
        private string m_transportType;
        
        public WaterTransportFactory(string transportType)
        {
            this.m_transportType = transportType;
        }


        public ITransport CreateTransport()
        {
            ITransport instance = null;
            if (m_transportType == "Ship")
                {
                    instance = new TransportByShip();
                }
                else if (m_transportType == "Ferry")
                {
                    instance = new TransportByFerry();
                }
                else
                {
                    Console.WriteLine("Invalid transport type.");
                }
                return instance;
        }
    }
}
