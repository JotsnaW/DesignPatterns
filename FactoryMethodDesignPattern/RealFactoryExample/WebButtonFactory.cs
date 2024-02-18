namespace RealFactoryExample
{
    public class WebButtonFactory : IButtonFactory
    {
        public IButton CreateButton()
        {
            return new WebButton();
        }
    }
}
