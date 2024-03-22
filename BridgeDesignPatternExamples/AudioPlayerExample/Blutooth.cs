using System;

namespace AudioPlayerExample
{
    public class Blutooth : IAudioDevices
    {
        public void Connect()
        {
            Console.WriteLine("Connecting to Blutooth device...");
        }

        public void Disconnect()
        {
            Console.WriteLine("Disconnecting Blutooth...");
        }
    }
}
