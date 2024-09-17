using GUIExample.Products;

namespace GUIExample.Factory
{
    public class MacFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new MacButton();
        }

        public ITextBox CreateTextBox()
        {
            return new MacTextbox();
        }
    }
}
