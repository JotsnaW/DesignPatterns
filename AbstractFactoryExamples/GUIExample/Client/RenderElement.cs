using GUIExample.Factory;

namespace GUIExample.Client
{
    public class RenderElement
    {

        public void Execute(IGUIFactory factory)
        {
            factory.CreateTextBox().Render();
            factory.CreateButton().Render();
        }
    }
}
