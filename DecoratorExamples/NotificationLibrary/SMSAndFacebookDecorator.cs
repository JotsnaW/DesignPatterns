namespace NotificationLibrary
{
    internal class SMSAndFacebookDecorator:INotifier
    {
        private INotifier m_notifier;
        public SMSAndFacebookDecorator(INotifier notifier)
        {
            m_notifier = notifier;
        }

        public void Send(string message)
        {
            m_notifier.Send("SMS_Facebook Notification: " + message);
        }

    }
}
