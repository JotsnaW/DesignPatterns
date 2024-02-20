namespace RealFactoryExample
{
    public class Program
    {
        public static void Main()
        {
            TransportFactory roadTransportfactory = new RoadTransportFactory();
            roadTransportfactory.CreateTransport().Deliver();

            TransportFactory waterTransportfactory = new WaterTransportFactory();
            waterTransportfactory.CreateTransport().Deliver();

            TransportFactory airTransportFactory = new AirTransportFactory();
            airTransportFactory.CreateTransport().Deliver();
        }
    }
}
