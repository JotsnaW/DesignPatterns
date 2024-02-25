namespace RealFactoryExample
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
