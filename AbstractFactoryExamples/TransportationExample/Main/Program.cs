using TransportationExample.Client;

namespace TransportationExample
{
    public class Program
    {
        public static void Main()
        {
            Deliver deliver = new Deliver();
            deliver.Execute(new WaterTransportFactory("Ferry"));
            deliver.Execute(new WaterTransportFactory("Ship"));

            deliver.Execute(new RoadTransportFactory("Truck"));
            deliver.Execute(new RoadTransportFactory("Car"));
        }
    }
}
