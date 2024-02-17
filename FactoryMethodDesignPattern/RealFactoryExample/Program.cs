using System;

namespace RealFactoryExample
{
    public class Program
    {
        public static void Main()
        {
            //Create a Web Dialog and render
            DialogFactory windowDialog = new WindowDialog();
            windowDialog.Render();

            //Create a Web Dialog and render
            DialogFactory webDialog = new WebDialog();
            webDialog.Render();

        }
    }
}
