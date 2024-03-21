using CustomComputerSystem.Product;

namespace CustomComputerSystem.Builder
{
    public class ComputerBuilder : IComputerBuilder
    {
        Computer computer = new Computer();

        public IComputerBuilder SetCPU()
        {
            computer.CPU = "Nvidia";
            return this;
        }

        public IComputerBuilder SetGraphicsCard()
        {
           computer.GraphicsCard = "INTEL CORE i7";
            return this;
        }

        public IComputerBuilder SetOperatingSystem()
        {
            computer.OperatingSystem = "Window 11";
            return this;
        }

        public IComputerBuilder SetRAM()
        {
           computer.RAM = "16GB";
            return this;
        }
        public Computer BuildComputer()
        {
            return computer;
        }
    }
}
