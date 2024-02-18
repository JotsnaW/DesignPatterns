namespace RealFactoryExample
{
    public class WaterTransportFactory : TransportFactory
    {
        public override ITransport CreateTransport()
        {
            return new WaterTransport();
        }
    }
}
