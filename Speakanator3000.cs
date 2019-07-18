namespace ClassyElectronics
{
    public class Speakanator3000 : Turntable
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