namespace AudioPlayerExample
{
    public class Program
    {
        static void Main()
        {
            IAudioFormat mp3Audio = new MP3Audio(new Blutooth());
            mp3Audio.Play();
            mp3Audio.Pause();
            mp3Audio.Stop();

            IAudioFormat flacAudio = new FLACAudio(new Speaker());
            flacAudio.Play();
            flacAudio.Pause();
            flacAudio.Stop();
        }
    }
}
