using HouseBuilderExample.Builder;

namespace HouseBuilderExample.Director
{
    public class FarmHouseDirector
    {
        private readonly IFarmHouseBuilder m_builder;

        public FarmHouseDirector(IFarmHouseBuilder builder)
        {
            m_builder = builder;
        }
        public void ConstructFarmHouse()
        {
            m_builder.BuildWalls("Brick");
            m_builder.BuildWindows("Wooden");
            m_builder.BuildRoof("Concrete");
            m_builder.BuildDoor("Glass");
            m_builder.BuildGarden("Flower Garden");
        }
    }
}
