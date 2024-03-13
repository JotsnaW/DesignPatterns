namespace FactoryMethodDesignPattern
{
    public class RoadTransportFactory : TransportFactory
    {
        public override ITransport CreateTransport()
        {
            //we can change this object creation based on user need. 
            return new TransportByCar();
        }
    }
}
