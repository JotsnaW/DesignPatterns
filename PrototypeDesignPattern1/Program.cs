namespace PrototypeDesignPattern1
{
    internal class Program
    {
        public static void Main()
        {
            Circle circle = new Circle(10);
            IComponent duplicateCircle = new ContextMenu().Duplicate(circle);
            duplicateCircle.Render();

            Rectangle rectangle = new Rectangle(10, 20);
            IComponent duplicateRectangle = new ContextMenu().Duplicate(rectangle);
            duplicateRectangle.Render();
        }
    }
}
