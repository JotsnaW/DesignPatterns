using CustomComputerSystem.Builder;
using CustomComputerSystem.Director;
using CustomComputerSystem.Product;

namespace CustomComputerSystem
{
    public class Program
    {
        static void Main()
        {
            IComputerBuilder builder = new ComputerBuilder();
            ComputerDirector director = new ComputerDirector(builder);
            director.ConstructComputer();

            Computer computer = builder.BuildComputer();
            computer.ShowDetails();

            ILaptopBuilder laptopBuilder = new LaptopBuilder();
            LaptopDirector laptopDirector = new LaptopDirector(laptopBuilder);
            laptopDirector.ConstructLaptop();

            Laptop laptop = laptopBuilder.BuildLaptop();
            laptop.ShowDetails();
        }
    }
}
