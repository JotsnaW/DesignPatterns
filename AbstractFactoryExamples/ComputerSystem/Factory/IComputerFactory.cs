using ComputerSystem.Product;

namespace ComputerSystem.Factory
{
    public interface IComputerFactory
    {
        IComputer CreateComputer();
    }
}
