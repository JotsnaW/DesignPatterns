using System;

namespace HouseBuilder_UsingSingleBuilder.Product
{
    public class House
    {
        public string Walls { get; set; }
        public string Window { get; set; }
        public string Roof { get; set; }
        public string Door { get; set; }
        public string Garden { get; set; }

        public void DisplayFarmHouseDetails()
        {
            Console.WriteLine($"Building House with {Walls} Walls, {Window} Window, {Roof} Roof, {Door} Door and {Garden} Garden.");
        }

        public void DisplayRegularHouseDetails()
        {
            Console.WriteLine($"Building House with {Walls} Walls, {Window} Window, {Roof} Roof and {Door} Door.");
        }

    }
}
