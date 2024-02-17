using System;

namespace RealFactoryExample
{
    public class WindowButton: IButton
    {
        public void Render()
        {
            Console.WriteLine("Rendering Window button.");
        }
    }
}
