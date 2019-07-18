using System.Collections.Generic;

namespace ClassyElectronics
{
    public interface IRadio
    {
        double CurrentFrequency { get; set; }
        List<double> FavoriteStations { get; set; }

        void AddFavorite();

        void RemoveFavorite(double station);
    }
}