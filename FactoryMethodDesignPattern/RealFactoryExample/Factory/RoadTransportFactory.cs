namespace RealFactoryExample
{
    public class RoadTransportFactory : TransportFactory
    {
        public override ITransport CreateTransport()
        {
            return new RoadTransport();
        }
    }
}
