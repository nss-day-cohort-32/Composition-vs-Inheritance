namespace ClassyElectronics
{
    public interface ITurntable
    {
        double CurrentSpeed { get; set; }
        bool IsPlaying { get; set; }

        void Play();

        void Stop();
    }
}