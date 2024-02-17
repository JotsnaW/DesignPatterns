namespace RealFactoryExample
{
    public class WebDialog : DialogFactory
    {
        protected override IButton CreateButton()
        {
            return new WebButton();
        }
    }
}
