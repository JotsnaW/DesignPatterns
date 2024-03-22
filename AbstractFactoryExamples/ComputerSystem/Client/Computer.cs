using ComputerSystem.Factory;

namespace ComputerSystem.Client
{
    public class Computer
    {
        public void GetComputer(IComputerFactory factory)
        {
            factory.CreateComputer().ShowDetails();
        }
    }
}
