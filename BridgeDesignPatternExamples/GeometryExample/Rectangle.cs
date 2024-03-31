using System;

namespace GeometryExample
{
    public class Rectangle: IShape
    {
        private IRender m_render;
        public Rectangle(IRender render)
        {
            this.m_render = render;
        }

        public void Draw()
        {
            Console.WriteLine("Drawing Rectangle.");
            m_render.Rendering();
        }
    }
}
