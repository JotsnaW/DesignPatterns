namespace ShapePrototypeSystem
{
    public class Program
    {
        public static void Main()
        {
            Circle circle = new Circle(10);
            IComponent duplicateCircle = new ContextMenu().Duplicate(circle);
            duplicateCircle.Render();

            Line topLine = new Line(0,0,10,0);
            Line bottomLine = new Line(0,5,10,5);
            Line leftLine = new Line(0, 0, 0,5);
            Line rightLine = new Line(10,0,10,5);

            Rectangle rectangle = new Rectangle(topLine, bottomLine, leftLine, rightLine);
            IComponent duplicateRectangle = new ContextMenu().Duplicate(rectangle);
            duplicateRectangle.Render();
        }
    }
}
