namespace NotificationLibrary
{
    public  class SMSDecorator : BaseDecorator
    {
        public SMSDecorator(INotifier notifier) : base(notifier) 
        {
          
        }

        public override void Send(string message)
        {
            base.Send("SMS Notification:" + message);
        }
    }
}
