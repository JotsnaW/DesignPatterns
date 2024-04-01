namespace NotificationLibrary
{
    internal class Program
    {
        static void Main()
        {
            INotifier baseNotifier = new BaseNotifier();

            baseNotifier = new SMSDecorator(baseNotifier);

            baseNotifier =  new FacebookDecorator(baseNotifier);
            
            baseNotifier = new SMSAndFacebookDecorator(baseNotifier);

            baseNotifier.Send("Hello there!!");
        }
    }
}
