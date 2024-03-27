using HouseBuilder_UsingMultipleBuilders.Builder;
using HouseBuilder_UsingMultipleBuilders.Director;
using HouseBuilder_UsingMultipleBuilders.Product;

namespace HouseBuilder_UsingMultipleBuilders
{
    internal class Program
    {
        static void Main()
        {
            IRegularHouseBuilder houseBuilder = new RegularHouseBuilder();

            RegularHouseDirector director = new RegularHouseDirector(houseBuilder);
            director.ConstructHouse();
            RegularHouse house = houseBuilder.BuildHouse();
            house.Display();

            IFarmHouseBuilder farmHouseBuilder = new FarmHouseBuilder();
            FarmHouseDirector farmHouseDirector = new FarmHouseDirector(farmHouseBuilder);
            farmHouseDirector.ConstructFarmHouse();
            FarmHouse farmHouse = farmHouseBuilder.BuildFarmHouse();
            farmHouse.Display();

        }
    }
}
