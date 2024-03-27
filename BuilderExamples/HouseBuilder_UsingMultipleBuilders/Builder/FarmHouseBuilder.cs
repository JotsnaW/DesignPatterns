using HouseBuilder_UsingMultipleBuilders.Product;

namespace HouseBuilder_UsingMultipleBuilders.Builder
{
    public class FarmHouseBuilder : IFarmHouseBuilder
    {
        private FarmHouse farmHouse = new FarmHouse();
        public IFarmHouseBuilder BuildDoor(string door)
        {
            farmHouse.Door = door;
            return this;
        }
        public IFarmHouseBuilder BuildGarden(string garden)
        {
            farmHouse.Garden = garden;
            return this;
        }
        public IFarmHouseBuilder BuildRoof(string roof)
        {
            farmHouse.Roof = roof;
            return this;
        }

        public IFarmHouseBuilder BuildWalls(string walls)
        {
            farmHouse.Walls = walls;
            return this;
        }

        public IFarmHouseBuilder BuildWindows(string window)
        {
            farmHouse.Window = window;
            return this;
        }
        public FarmHouse BuildFarmHouse()
        {
            return farmHouse;
        }

    }
}
