using System;

namespace RealFactoryExample
{
    public class WebButton: IButton
    {
        public void Render()
        {
            Console.WriteLine("Rendering Web Button.");
        }
    }
}
