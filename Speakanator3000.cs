namespace ClassyElectronics
{
    public class Speakanator3000
    {
        public ITurntable TurnTable { get; set; }
        public ISpeaker Speaker { get; set; }

        public Speakanator3000(ITurntable turnTable, ISpeaker speaker)
        {
            TurnTable = turnTable;
            Speaker = speaker;
        }
    }
}