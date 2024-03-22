using GUIExample.Client;
using GUIExample.Factory;

namespace AbstractFactoryExample2
{
    public class Program
    {
        public static void Main()
        {
            RenderElement renderElement = new RenderElement();
            renderElement.Execute(new MacFactory());
            renderElement.Execute(new WinFactory());

        }
    }
}
