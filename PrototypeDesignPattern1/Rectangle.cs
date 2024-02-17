using System;

namespace PrototypeDesignPattern1
{
    internal class Rectangle : IComponent
    {
        private readonly double m_length;
        private readonly double m_width;
        private readonly double m_area;

        //constructor
        public Rectangle(double length, double width)
        {
            m_length = length;
            m_width = width;
            m_area = m_length * m_length;
        }

        // clone method
        public IComponent Clone()
        {
            Rectangle clonedRectangle = new Rectangle(m_length, m_width);
            return clonedRectangle;
        }

        // render method
        public void Render()
        {
            Console.WriteLine($"Rendering Rectangle with Length: {m_length}, Width: {m_width} and Area: {m_area}");
        }
    }
}
