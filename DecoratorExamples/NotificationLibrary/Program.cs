namespace NotificationLibrary
{
    internal class Program
    {
        public static void Main()
        {
            INotifier baseNotifier = new BaseNotifier();

            BaseDecorator smsDecorator = new SMSDecorator(baseNotifier);
            smsDecorator.Send("Sending notification using SMS service.");

            BaseDecorator facebookDecorator =  new FacebookDecorator(baseNotifier);
            facebookDecorator.Send("Sending notification using Facebook service.");

            BaseDecorator smsAndFacebookDecorator = new FacebookDecorator(new SMSDecorator(baseNotifier));
            smsAndFacebookDecorator.Send("Sending notification using Facebook + SMS service");
        }
    }
}
