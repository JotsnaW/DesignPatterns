using GUIExample.Products;

namespace GUIExample.Factory
{
    public interface IGUIFactory
    {
        IGUIElement CreateGUIElement();
    }
}
