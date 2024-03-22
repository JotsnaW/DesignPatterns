using System;

namespace GUIExample.Products
{
    public class WinTextbox: ITextBox
    {
        public void Render()
        {
            Console.WriteLine("Rendering Window Textbox...");
        }
    }
}
