using HouseBuilder_UsingMultipleBuilders.Product;

namespace HouseBuilder_UsingMultipleBuilders.Builder
{
    public class RegularHouseBuilder : IRegularHouseBuilder
    {
        private readonly RegularHouse house = new RegularHouse();

        public IRegularHouseBuilder BuildDoor(string door)
        {
            house.Door = door;
            return this;
        }
        public IRegularHouseBuilder BuildRoof(string roof)
        {
            house.Roof = roof;
            return this;
        }

        public IRegularHouseBuilder BuildWalls(string walls)
        {
            house.Walls = walls;
            return this;
        }

        public IRegularHouseBuilder BuildWindows(string window)
        {
            house.Window = window;
            return this;
        }
        public RegularHouse BuildHouse()
        {
            return house;
        }
    }
}
