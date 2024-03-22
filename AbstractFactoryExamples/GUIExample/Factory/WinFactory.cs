using GUIExample.Products;

namespace GUIExample.Factory
{
    public class WinFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new WinButton();
        }

        public ITextBox CreateTextBox()
        {
            return new WinTextbox();
        }
    }
}
