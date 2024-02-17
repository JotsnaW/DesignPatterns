namespace FactoryMethodDesignPattern
{
    public class Program
    {
       public static void Main()
        {
            ITransport airTransport = new TransportFactory().CreateFactory(TransportType.ByAir);
            airTransport.Deliver();

            ITransport roadTransport = new TransportFactory().CreateFactory(TransportType.ByRoad);
            roadTransport.Deliver();

            ITransport seaTransport = new TransportFactory().CreateFactory(TransportType.BySea);
            seaTransport.Deliver();
        }
    }
}
