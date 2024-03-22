using System;

namespace ComputerSystem.Product
{
    public interface IComputer
    {
        String GetRAM();
        String GetHDD();
        String GetCPU();

        void ShowDetails();
    }
}
