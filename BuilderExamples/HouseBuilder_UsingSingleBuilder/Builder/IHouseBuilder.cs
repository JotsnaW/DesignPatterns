using HouseBuilder_UsingSingleBuilder.Product;

namespace HouseBuilder_UsingSingleBuilder.Builder
{
    public interface IHouseBuilder
    {
        IHouseBuilder BuildWalls(string walls);
        IHouseBuilder BuildWindows(string window);
        IHouseBuilder BuildRoof(string roof);
        IHouseBuilder BuildDoor(string door);
        IHouseBuilder BuildGarden(bool hasGarden);
        House BuildHouse();
    }
}
