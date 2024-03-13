using GUIExample.Client;
using GUIExample.Factory;

namespace AbstractFactoryExample2
{
    public class Program
    {
        public static void Main()
        {
            RenderElement renderElement = new RenderElement();
            renderElement.Render(new MacFactory());

            renderElement.Render(new WinFactory());

        }
    }
}
