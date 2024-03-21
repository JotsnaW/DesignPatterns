namespace LaptopPowerOutlet
{
    public class Program
    {
        public static void Main()
        {
            IThreePinOutlet threePinOutlet = new Laptop();
            ITwoPinOutlet adapter = new PowerAdapter(threePinOutlet);

            adapter.ConnectTwoPin();

        }
    }
}
