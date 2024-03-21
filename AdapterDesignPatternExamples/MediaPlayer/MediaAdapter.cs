using System;

namespace MediaPlayer
{
    public class MediaAdapter : ILegacyMediaPlayer
    {
        private readonly IModernMediaPlayer m_mediaPlayer;

        public MediaAdapter(IModernMediaPlayer mediaPlayer)
        {
            m_mediaPlayer = mediaPlayer;
        }

        public void Play(string fileName)
        {
            if(fileName.EndsWith(".WAV", StringComparison.OrdinalIgnoreCase))
            {
                m_mediaPlayer.PlayWAVAudio(fileName);
            }
            else if(fileName.EndsWith(".FLAC", StringComparison.OrdinalIgnoreCase))
            {
                m_mediaPlayer.PlayFLACAudio(fileName);
            }
            else if(fileName.EndsWith(".mp3", StringComparison.OrdinalIgnoreCase))
            {
                m_mediaPlayer.PlayMP3Audio(fileName);
            }
            else
            {
                Console.WriteLine("Unsupported file format" + fileName);
            }
        }
    }
}
