using CustomComputerSystem.Product;

namespace CustomComputerSystem.Builder
{
    public interface ILaptopBuilder
    {
        ILaptopBuilder SetGraphicsCard();
        ILaptopBuilder SetCPU();
        ILaptopBuilder SetRAM();
        ILaptopBuilder SetOperatingSystem();

        Laptop BuildLaptop();
    }
}
