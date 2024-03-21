using System;

namespace LaptopPowerOutlet
{
    internal class Laptop : IThreePinOutlet
    {
        public void ConnectThreePin()
        {
            Console.WriteLine("Connecting laptop using 3 pin power outlet.");
        }
    }
}
