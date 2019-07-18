using System;

namespace ClassyElectronics
{
    class Program
    {
        static void Main(string[] args)
        {
            Speakanator3000 speakanator = new Speakanator3000(
                new BasicTurntable(),
                new BasicSpeaker()
            );

            Radionator4000 radionator = new Radionator4000(
                new BasicTurntable(),
                new BasicSpeaker(),
                new BasicRadio()
            );

            Radionator4000 betterRadionator = new Radionator4000(
                new BasicTurntable(),
                new BasicSpeaker(),
                new BetterRadio() // Composing this with a better radio
            );

            radionator.Radio.AddFavorite();
        }
    }
}