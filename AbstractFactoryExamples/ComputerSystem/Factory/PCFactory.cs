using ComputerSystem.Product;

namespace ComputerSystem.Factory
{
    public class PCFactory : IComputerFactory
    {
        string CPU { get; set; }
        string RAM { get; set; }
        string HDD { get; set; }
        public PCFactory(string cpu, string ram, string hdd) 
        {
            CPU = cpu;
            RAM = ram;
            HDD = hdd;
        }
        public IComputer CreateComputer()
        {
           return new PC(CPU, RAM, HDD);
        }
    }
}
