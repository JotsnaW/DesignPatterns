namespace FactoryMethodDesignPattern
{
    public class Program
    {
       public static void Main()
        {
            ITransport airTransport = new TransportFactory().CreateFactory(TransportType.ByAir);
            airTransport.Transport();

            ITransport roadTransport = new TransportFactory().CreateFactory(TransportType.ByRoad);
            roadTransport.Transport();

            ITransport waterTransport = new TransportFactory().CreateFactory(TransportType.BySea);
            waterTransport.Transport();
        }
    }
}
