using HouseBuilder_UsingSingleBuilder.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseBuilder_UsingSingleBuilder.Builder
{
    public class HouseBuilder : IHouseBuilder
    {
        private House m_house = new House();

        public IHouseBuilder BuildDoor(string door)
        {
            m_house.Door = door;
            return this;
        }
        public IHouseBuilder BuildGarden(string garden)
        {
            m_house.Garden = garden;
            return this;
        }
        public IHouseBuilder BuildRoof(string roof)
        {
            m_house.Roof = roof;
            return this;
        }

        public IHouseBuilder BuildWalls(string walls)
        {
            m_house.Walls = walls;
            return this;
        }

        public IHouseBuilder BuildWindows(string window)
        {
            m_house.Window = window;
            return this;
        }
        public House BuildHouse()
        {
            return m_house;
        }

    }
}
