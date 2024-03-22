using System;

namespace ComputerSystem.Product
{
    public class Laptop:IComputer
    {
        string CPU { get; set; }
        string RAM { get; set; }
        string HDD { get; set; }

        public Laptop(string cpu, string ram, string hdd)
        {
            CPU = cpu;
            RAM = ram;
            HDD = hdd;
        }
        public string GetCPU()
        {
            return this.CPU;
        }

        public string GetHDD()
        {
            return this.HDD;
        }

        public string GetRAM()
        {
            return this.RAM;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Laptop created with configurations: CPU: {CPU}, HDD: {HDD} and RAM: {RAM}");
        }
    }
}
