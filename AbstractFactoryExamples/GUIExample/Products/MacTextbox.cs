using System;

namespace GUIExample.Products
{
    public class MacTextbox: ITextBox
    {
        public void Render()
        {
            Console.WriteLine("Rendering Mac Textbox...");
        }
    }
}
