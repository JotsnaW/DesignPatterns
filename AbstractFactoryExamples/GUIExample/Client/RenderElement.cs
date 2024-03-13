using GUIExample.Factory;

namespace GUIExample.Client
{
    public class RenderElement
    {
        public void Render(IGUIFactory factory)
        {
            factory.CreateGUIElement().Render();
        }
    }
}
