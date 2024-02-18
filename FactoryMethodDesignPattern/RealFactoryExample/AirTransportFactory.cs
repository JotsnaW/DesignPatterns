namespace RealFactoryExample
{
    public class AirTransportFactory : TransportFactory
    {
        public override ITransport CreateTransport()
        {
            return new AirTransport();
        }
    }
}
