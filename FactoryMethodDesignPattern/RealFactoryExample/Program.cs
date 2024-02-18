using System;

namespace RealFactoryExample
{
    public class Program
    {
        public static void Main()
        {
            //Create a Window BUtton and render
            IButtonFactory windowButtonFactory = new WindowButtonFactory();
            Dialog windowDialog = new Dialog(windowButtonFactory);
            windowDialog.RenderDialog();

            //Create a Web BUtton and render
            IButtonFactory webButtonFactory = new WebButtonFactory();
            Dialog webDialog = new Dialog(webButtonFactory);
            webDialog.RenderDialog();
        }
    }
}
