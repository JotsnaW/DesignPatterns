namespace RealFactoryExample
{
    public class Transport
    {
        public void Execute(TransportFactory factory)
        {
            factory.CreateTransport().Transport();
        }

    }
}
