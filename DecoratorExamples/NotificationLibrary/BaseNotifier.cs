using System;

namespace NotificationLibrary
{
    internal class BaseNotifier : INotifier
    {
        public void Send(string message)
        {
            Console.WriteLine($"Base Notifier: {message}");
        }
    }
}
