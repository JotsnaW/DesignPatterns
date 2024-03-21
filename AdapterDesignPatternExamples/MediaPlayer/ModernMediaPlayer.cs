using System;

namespace MediaPlayer
{
    public class ModernMediaPlayer : IModernMediaPlayer
    {
        public void PlayFLACAudio(string fileName)
        {
            Console.WriteLine("Playing FLAC file: " + fileName);
        }
        public void PlayWAVAudio(string fileName)
        {
            Console.WriteLine("Playing WAV file: " + fileName);
        }
        public void PlayMP3Audio(string fileName)
        {
            Console.WriteLine("Playing MP3 file: " + fileName);
        }
    }
}
