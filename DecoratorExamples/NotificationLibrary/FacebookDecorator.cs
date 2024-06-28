namespace NotificationLibrary
{
    public class FacebookDecorator : BaseDecorator
    {
        public FacebookDecorator(INotifier notifier) : base(notifier)
        { 

        }

        public override void Send(string message)
        {
            base.Send($"{message}");
        }
    }
}
