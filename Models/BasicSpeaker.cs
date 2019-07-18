namespace ClassyElectronics
{
    public class BasicSpeaker : ISpeaker
    {
        public int Volume { get; set; }

        public void VolumeUp()
        {
            Volume += 1;
        }

        public void VolumeDown()
        {
            Volume -= 1;
        }
    }
}