using System;

namespace HouseBuilder_UsingSingleBuilder.Product
{
    public class House
    {
        public string Walls { get; set; }
        public string Window { get; set; }
        public string Roof { get; set; }
        public string Door { get; set; }
        public bool HasGarden { get; set; }

        public void DisplayFarmHouseDetails()
        {
            Console.WriteLine($"Building House with {Walls} Walls, {Window} Window, {Roof} Roof, {Door} Door and with Garden.");
        }

        public void DisplayRegularHouseDetails()
        {
            Console.WriteLine($"Building House with {Walls} Walls, {Window} Window, {Roof} Roof and {Door} Door.");
        }

    }
}
