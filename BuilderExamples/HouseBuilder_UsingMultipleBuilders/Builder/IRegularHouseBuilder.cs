using HouseBuilder_UsingMultipleBuilders.Product;

namespace HouseBuilder_UsingMultipleBuilders.Builder
{
    public interface IRegularHouseBuilder
    {
        IRegularHouseBuilder BuildWalls(string walls);
        IRegularHouseBuilder BuildWindows(string window);
        IRegularHouseBuilder BuildRoof(string roof);
        IRegularHouseBuilder BuildDoor(string door);
        RegularHouse BuildHouse();
    }
}
