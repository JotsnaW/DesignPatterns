using System;

namespace ShapePrototypeSystem
{
    public class Rectangle: IComponent
    {
        private Line TopLine {  get; set; }
        private Line BottomLine { get; set; }
        private Line LeftLine { get; set; }
        private Line RightLine { get; set; }


        //constructor
        public Rectangle(Line topLine, Line bottomLine, Line leftLine, Line rightLine)
        {
            TopLine = topLine;
            BottomLine = bottomLine;
            LeftLine = leftLine;
            RightLine = rightLine;
        }

        // clone method
        public IComponent Clone()
        {
            Rectangle clonedRectangle = new Rectangle(TopLine.DeepClone(), BottomLine.DeepClone(), LeftLine.DeepClone(), RightLine.DeepClone());
            return clonedRectangle;
        }

        // render method
        public void Render()
        {
            Console.WriteLine($"Rendering Rectangle with:");
            Console.WriteLine($"TopLine:({TopLine.X1}, {TopLine.Y1}, {TopLine.X2}, {TopLine.Y2})");
            Console.WriteLine($"BottomLine: ({BottomLine.X1},{BottomLine.Y1},{BottomLine.X2},{BottomLine.Y2})");
            Console.WriteLine($"LeftLine: ({LeftLine.X1}, {LeftLine.Y1}, {LeftLine.X2}, {LeftLine.Y2})");
            Console.WriteLine($"RightLine: ({RightLine.X1}, {RightLine.Y1}, {RightLine.X2}, {RightLine.Y2})");
        }
    }
}
