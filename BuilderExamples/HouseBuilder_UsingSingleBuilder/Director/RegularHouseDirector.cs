using HouseBuilder_UsingSingleBuilder.Builder;

namespace HouseBuilder_UsingSingleBuilder.Director
{
    public class RegularHouseDirector
    {
        private readonly IHouseBuilder m_builder;

        public RegularHouseDirector(IHouseBuilder builder)
        {
            m_builder = builder;
        }
        public void ConstructHouse()
        {
            m_builder.BuildWalls("Concrete");
            m_builder.BuildWindows("Glass");
            m_builder.BuildRoof("Tile");
            m_builder.BuildDoor("Wooden");
        }
    }
}
