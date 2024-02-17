namespace RealFactoryExample
{
    public class WindowDialog : DialogFactory
    {
        protected override IButton CreateButton()
        {
            return new WindowButton();
        }
        
    }
}
