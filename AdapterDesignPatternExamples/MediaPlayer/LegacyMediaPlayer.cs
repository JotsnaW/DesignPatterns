using System;

namespace MediaPlayer
{
    public class LegacyMediaPlayer : ILegacyMediaPlayer
    {
        public void Play(string fileName)
        {
            Console.WriteLine("Playing MP3 file: " + fileName);
        }
    }
}
