namespace NotificationLibrary
{
    public abstract class BaseDecorator: INotifier
    {
        private INotifier m_notifier;
        public BaseDecorator(INotifier notifier) 
        { 
            m_notifier = notifier;
        }
        public virtual void Send(string message)
        {
            m_notifier.Send(message);
        }
    }
}
