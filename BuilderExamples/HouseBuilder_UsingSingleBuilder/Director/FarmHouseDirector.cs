using HouseBuilder_UsingSingleBuilder.Builder;

namespace HouseBuilder_UsingSingleBuilder.Director
{
    public class FarmHouseDirector
    {
        private readonly IHouseBuilder m_builder;

        public FarmHouseDirector(IHouseBuilder builder)
        {
            m_builder = builder;
        }
        public void ConstructFarmHouse()
        {
            m_builder.BuildWalls("Brick");
            m_builder.BuildWindows("Wooden");
            m_builder.BuildRoof("Concrete");
            m_builder.BuildDoor("Glass");
            m_builder.BuildGarden(true);
        }
    }
}
