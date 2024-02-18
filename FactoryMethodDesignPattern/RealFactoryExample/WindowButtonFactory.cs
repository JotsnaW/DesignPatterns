namespace RealFactoryExample
{
    public class WindowButtonFactory : IButtonFactory
    {
        public IButton CreateButton()
        {
            return new WindowButton();
        }
    }
}
