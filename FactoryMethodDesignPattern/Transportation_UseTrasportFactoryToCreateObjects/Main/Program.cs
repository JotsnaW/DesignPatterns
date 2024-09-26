namespace FactoryMethodDesignPattern
{
    public class Program
    {
       public static void Main()
        {
            ITransport airTransport = new TransportFactory().CreateFactory(TransportType.Air);
            airTransport.Transport();

            ITransport roadTransport = new TransportFactory().CreateFactory(TransportType.Road);
            roadTransport.Transport();

            ITransport waterTransport = new TransportFactory().CreateFactory(TransportType.Water);
            waterTransport.Transport();
        }
    }
}
