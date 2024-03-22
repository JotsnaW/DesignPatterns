using ComputerSystem.Client;
using ComputerSystem.Factory;

namespace ComputerSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer();
            computer.GetComputer(new PCFactory("2 GB", "500 GB", "2.4 GHz"));
            computer.GetComputer(new LaptopFactory("1 GB", "1000 GB", "2.4 GHz"));
        }
    }
}
