using System;

namespace FactoryMethodDesignPattern
{
    public enum TransportType
    {
        Road,
        Water,
        Air
    }
    public class TransportFactory
    {
        public ITransport CreateFactory(TransportType transportType)
        {
            switch (transportType) 
            {
                case TransportType.Road:
                    return new Road();

                case TransportType.Water:
                    return new Water();

                case TransportType.Air:
                    return  new Air();
                default:
                    throw new ArgumentException("Invalid Transport Type");
            }
        }    
    }
}
