using CustomComputerSystem.Product;

namespace CustomComputerSystem.Builder
{
    public class LaptopBuilder: ILaptopBuilder
    {
        Laptop laptop = new Laptop();

        public ILaptopBuilder SetCPU()
        {
            laptop.CPU = "Nvidia";
            return this;
        }

        public ILaptopBuilder SetGraphicsCard()
        {
            laptop.GraphicsCard = "INTEL CORE i7";
            return this;
        }

        public ILaptopBuilder SetOperatingSystem()
        {
            laptop.OperatingSystem = "Window 11";
            return this;
        }

        public ILaptopBuilder SetRAM()
        {
            laptop.RAM = "16GB";
            return this;
        }
        public Laptop BuildLaptop()
        {
            return laptop;
        }
    }
}
