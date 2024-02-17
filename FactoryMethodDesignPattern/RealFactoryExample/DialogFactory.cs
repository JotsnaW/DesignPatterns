using System;

namespace RealFactoryExample
{
    public abstract class DialogFactory
    {
        protected abstract IButton CreateButton();

        public void Render()
        {
            IButton button = CreateButton();
            Console.WriteLine("Rendering Dialog of type " + button.GetType().Name);
            button.Render();
        }
    }
}
