namespace NotificationLibrary
{
    internal class Program
    {
        public static void Main()
        {
            INotifier baseNotifier = new BaseNotifier();

            BaseDecorator smsDecorator = new SMSDecorator(baseNotifier);
            smsDecorator.Send("This is SMS Decorator");

            BaseDecorator facebookDecorator =  new FacebookDecorator(baseNotifier);
            facebookDecorator.Send("This is Facebook Decorator.");

            BaseDecorator smsAndFacebookDecorator = new FacebookDecorator(new SMSDecorator(baseNotifier));
            smsAndFacebookDecorator.Send("This is SMS+Facebook Decorator.");
        }
    }
}
