using GUIExample.Products;

namespace GUIExample.Factory
{
    public class WinFactory : IGUIFactory
    {
        public IGUIElement CreateGUIElement()
        {
            return new WinButton();
        }
    }
}
