using System;

namespace GUIExample.Products
{
    internal class WinButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Rendering Window Button...");
        }

    }
}
