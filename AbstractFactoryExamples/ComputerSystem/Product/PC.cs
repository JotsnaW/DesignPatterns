using System;

namespace ComputerSystem.Product
{
    public class PC : IComputer
    {
        string CPU {  get; set; }
        string RAM { get; set; }
        string HDD { get; set; }

        public PC(string cpu, string ram, string hdd) 
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
            Console.WriteLine($"PC created with configurations: CPU: {CPU}, HDD: {HDD} and RAM: {RAM}");
        }
    }
}
