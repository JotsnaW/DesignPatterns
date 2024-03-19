namespace FactoryMethodDesignPattern
{
    public class Program
    {
        public static void Main()
        {
            Transport transport = new Transport();
            transport.Execute(new RoadTransportFactory());

        }
    }
}
