using System;

namespace RealFactoryExample
{
    public class Dialog
    {
        private readonly IButtonFactory m_buttonFactory;

        public Dialog(IButtonFactory buttonFactory)
        {
            m_buttonFactory = buttonFactory;
        }

        public void RenderDialog()
        {
            IButton button = m_buttonFactory.CreateButton();
            button.Render();
        }
    }
}
