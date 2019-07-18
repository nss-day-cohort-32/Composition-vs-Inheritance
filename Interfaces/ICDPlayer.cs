namespace ClassyElectronics
{
    public interface ICDPlayer
    {
        int TotalTracks { get; set; }
        int CurrentTrack { get; set; }

        void NextTrack();

        void PreviousTrack();
    }
}