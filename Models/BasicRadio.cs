using System.Collections.Generic;

namespace ClassyElectronics
{
    public class BasicRadio : IRadio
    {
        public double CurrentFrequency { get; set; }
        public List<double> FavoriteStations { get; set; }

        public void AddFavorite()
        {
            FavoriteStations.Add(CurrentFrequency);
        }

        public void RemoveFavorite(double station)
        {
            FavoriteStations.Remove(station);
        }
    }
}