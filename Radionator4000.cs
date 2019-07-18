using System.Collections.Generic;

namespace ClassyElectronics
{
    public class Radionator4000
    {
        public ITurntable Turntable { get; set; }
        public ISpeaker Speaker { get; set; }
        public IRadio Radio { get; set; }

        public Radionator4000(
            ITurntable turntable,
            ISpeaker speaker,
            IRadio radio
        )
        {
            Turntable = turntable;
            Speaker = speaker;
            Radio = radio;
        }
    }
}