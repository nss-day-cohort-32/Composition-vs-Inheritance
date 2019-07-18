namespace ClassyElectronics
{
    public class Discotron5000 : Radionator4000
    {
        public int TotalTracks { get; set; }
        public int CurrentTrack { get; set; }

        public void NextTrack()
        {
            CurrentTrack += 1;
        }

        public void PreviousTrack()
        {
            CurrentTrack -= 1;
        }
    }
}