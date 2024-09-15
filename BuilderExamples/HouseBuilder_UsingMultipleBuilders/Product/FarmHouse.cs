using System;

namespace HouseBuilder_UsingMultipleBuilders.Product
{
    public class FarmHouse
    {
            public string Walls { get; set; }
            public string Window { get; set; }
            public string Roof { get; set; }
            public string Door { get; set; }
            public string Garden {  get; set; }

            public void Display()
            {
                Console.WriteLine($"Building House with {Walls} Walls, {Window} Window, {Roof} Roof, {Door} Door and {Garden} Garden.");
            }
    }
}
