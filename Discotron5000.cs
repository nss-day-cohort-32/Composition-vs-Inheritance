namespace ClassyElectronics
{
    public class Discotron5000
    {
        public ITurntable Turntable { get; set; }
        public ISpeaker Speaker { get; set; }
        public IRadio Radio { get; set; }
        public ICDPlayer CdPlayer { get; set; }

        public Discotron5000(
            ITurntable turntable,
            ISpeaker speaker,
            IRadio radio,
            ICDPlayer cdPlayer
        )
        {
            Turntable = turntable;
            Speaker = speaker;
            Radio = radio;
            CdPlayer = cdPlayer;
        }
    }
}