using System;

namespace AudioPlayerExample
{
    public class MP3Audio: IAudioFormat
    {
        private IAudioDevices m_device;
        public MP3Audio(IAudioDevices device)
        {
            m_device = device;  
        }

        public void Pause()
        {
            Console.WriteLine("Audio paused.");
        }

        public void Play()
        {
            m_device.Connect();
            Console.WriteLine("Audio started...");
        }

        public void Stop()
        {
            Console.WriteLine("Audio stopped.");
            m_device.Disconnect();
        }
    }
}
