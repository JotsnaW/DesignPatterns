using System;

namespace GeometryExample
{
    public class Circle:IShape
    {
        private IRender m_render;
        public Circle(IRender render)
        {
            this.m_render = render;
        }

        public void Draw()
        {
            Console.WriteLine("Drawing Circle.");
            m_render.Rendering();
        }

    }
}
