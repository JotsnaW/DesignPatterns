using System;

namespace GUIExample.Products
{
    public class MacButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Rendering Mac Button...");
        }
    }
}
