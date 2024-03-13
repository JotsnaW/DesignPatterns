using GUIExample.Products;

namespace GUIExample.Factory
{
    public class MacFactory : IGUIFactory
    {
        public IGUIElement CreateGUIElement()
        {
            return new MacButton();
        }
    }
}
