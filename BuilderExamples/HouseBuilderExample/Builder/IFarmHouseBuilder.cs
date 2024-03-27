﻿using HouseBuilderExample.Product;

namespace HouseBuilderExample.Builder
{
    public interface IFarmHouseBuilder
    {
        IFarmHouseBuilder BuildWalls(string walls);
        IFarmHouseBuilder BuildWindows(string window);
        IFarmHouseBuilder BuildRoof(string roof);
        IFarmHouseBuilder BuildDoor(string door);
        IFarmHouseBuilder BuildGarden(string garden);
        FarmHouse BuildFarmHouse();
    }
}