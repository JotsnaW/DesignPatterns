namespace MediaPlayer
{
    public interface IModernMediaPlayer
    {
        void PlayWAVAudio(string fileName);
        void PlayFLACAudio(string fileName);
        void PlayMP3Audio(string fileName);
    }
}
