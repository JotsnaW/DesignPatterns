using HouseBuilder_UsingSingleBuilder.Builder;
using HouseBuilder_UsingSingleBuilder.Director;
using HouseBuilder_UsingSingleBuilder.Product;

namespace HouseBuilder_UsingSingleBuilder.Client
{
    internal class Program
    {
        static void Main()
        {
            IHouseBuilder builder = new HouseBuilder();
            FarmHouseDirector farmHouseDirector = new FarmHouseDirector(builder);
            farmHouseDirector.ConstructFarmHouse();
            House farmHouse = builder.BuildHouse();
            farmHouse.DisplayFarmHouseDetails();

            RegularHouseDirector regularHouseDirector = new RegularHouseDirector(builder);
            regularHouseDirector.ConstructHouse();
            House regularHouse = builder.BuildHouse();
            regularHouse.DisplayRegularHouseDetails();

        }
    }
}
