using System;

namespace FactoryMethodDesignPattern
{
    public enum TransportType
    {
        ByRoad,
        BySea,
        ByAir
    }
    public class TransportFactory
    {
        public ITransport CreateFactory(TransportType transportType)
        {
            switch (transportType) 
            {
                case TransportType.ByRoad:
                    return new RoadTransport();

                case TransportType.BySea:
                    return new SeaTransport();

                case TransportType.ByAir:
                    return  new AirTransport();
                default:
                    throw new ArgumentException("Invalid Transport Type");
            }
        }    
    }
}
