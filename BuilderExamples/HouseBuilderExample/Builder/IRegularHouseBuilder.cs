using HouseBuilderExample.Product;

namespace HouseBuilderExample.Builder
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
