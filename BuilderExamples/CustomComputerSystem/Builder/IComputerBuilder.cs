using CustomComputerSystem.Product;

namespace CustomComputerSystem.Builder
{
    public interface IComputerBuilder
    {
        IComputerBuilder SetGraphicsCard();
        IComputerBuilder SetCPU();
        IComputerBuilder SetRAM();
        IComputerBuilder SetOperatingSystem();

        Computer BuildComputer();
    }
}
