namespace GeometryExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            IShape circle = new Circle(new RasterRendering());
            circle.Draw();

            IShape rectangle = new Rectangle(new VectorRendering());
            rectangle.Draw();
        }
    }
}
