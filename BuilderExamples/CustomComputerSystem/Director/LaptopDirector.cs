using CustomComputerSystem.Builder;

namespace CustomComputerSystem.Director
{
    public class LaptopDirector
    {
        private ILaptopBuilder m_builder = new LaptopBuilder();
        public LaptopDirector(ILaptopBuilder builder)
        {
            m_builder = builder;
        }

        public void ConstructLaptop()
        {
            m_builder.SetGraphicsCard();
            m_builder.SetCPU();
            m_builder.SetRAM();
            m_builder.SetOperatingSystem();
        }
    }
}
