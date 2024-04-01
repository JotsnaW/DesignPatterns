using CustomComputerSystem.Builder;

namespace CustomComputerSystem.Director
{
    internal class ComputerDirector
    {
        private readonly IComputerBuilder m_builder = new ComputerBuilder();
        public ComputerDirector(IComputerBuilder builder)
        {
           m_builder = builder;
        }

        public void ConstructComputer()
        {
            m_builder.SetGraphicsCard();
            m_builder.SetCPU();
            m_builder.SetRAM();
            m_builder.SetOperatingSystem();
        }
    }
}
