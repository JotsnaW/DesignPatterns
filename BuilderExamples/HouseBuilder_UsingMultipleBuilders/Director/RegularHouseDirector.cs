using HouseBuilder_UsingMultipleBuilders.Builder;

namespace HouseBuilder_UsingMultipleBuilders
{
    public class RegularHouseDirector
    {
        private readonly IRegularHouseBuilder m_builder;

        public RegularHouseDirector(IRegularHouseBuilder builder)
        {
            m_builder = builder;
        }
        public void ConstructHouse()
        {
            m_builder.BuildWalls("Concrete");
            m_builder.BuildWindows("Glass");
            m_builder.BuildRoof("Tile");
            m_builder.BuildDoor("Wood");
        }
    }
}
