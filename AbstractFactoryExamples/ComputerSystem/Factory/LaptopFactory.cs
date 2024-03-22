using ComputerSystem.Product;

namespace ComputerSystem.Factory
{
    public class LaptopFactory: IComputerFactory
    {
        string CPU { get; set; }
        string RAM { get; set; }
        string HDD { get; set; }
        public LaptopFactory(string cpu, string ram, string hdd)
        {
            CPU = cpu;
            RAM = ram;
            HDD = hdd;
        }
        public IComputer CreateComputer()
        {
            return new Laptop(CPU, RAM, HDD);
        }
    }
}
