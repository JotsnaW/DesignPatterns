using GUIExample.Products;

namespace GUIExample.Factory
{
    public interface IGUIFactory
    {
        IButton CreateButton();
        ITextBox CreateTextBox();
    }
}
