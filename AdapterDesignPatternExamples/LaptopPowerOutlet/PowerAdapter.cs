namespace LaptopPowerOutlet
{
    public class PowerAdapter : ITwoPinOutlet
    {
        private readonly IThreePinOutlet m_outlet;
        public PowerAdapter(IThreePinOutlet outlet) 
        {
            m_outlet = outlet;
        }
        public void ConnectTwoPin()
        {
            m_outlet.ConnectThreePin();
        }
    }
}
