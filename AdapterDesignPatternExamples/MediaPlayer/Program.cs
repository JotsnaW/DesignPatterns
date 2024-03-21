namespace MediaPlayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILegacyMediaPlayer legacyMediaPlayer = new MediaAdapter(new ModernMediaPlayer());

            legacyMediaPlayer.Play("song1.mp3");
            legacyMediaPlayer.Play("song2.FLAC");
            legacyMediaPlayer.Play("song3.WAV");
        }
    }
}
