using System;

namespace HouseBuilderExample.Product
{
    public class RegularHouse
    {
    public string Walls {  get; set; }
    public string Window { get; set; }
    public string Roof {  get; set; }
    public string Door {  get; set; }

        public void Display()
        {
            Console.WriteLine($"Building House with {Walls} Walls, {Window} Window, {Roof} Roof and {Door} Door.");
        }

    }
}
