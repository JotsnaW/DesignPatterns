using System;

namespace PrototypeDesignPattern1
{
    internal class Circle: IComponent
    {
        public double Radius {  get; set; }
        private readonly double m_perimeter;

        public Circle(double radius)
        {
            Radius = radius;
            m_perimeter = Radius / 2;
        }

        // clone method
        public IComponent Clone()
        {
            Circle clonedCircle = new Circle(Radius);
            return clonedCircle;
        }

        // render method
        public void Render()
        {
            Console.WriteLine($"Rendering Circle with Radius: {Radius} and Perimeter: {m_perimeter}");
        }
    }
}
