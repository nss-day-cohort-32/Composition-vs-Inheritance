using System;
using System.Collections.Generic;

namespace ClassyElectronics
{
    public class BetterRadio : IRadio
    {
        public double CurrentFrequency { get; set; }
        public List<double> FavoriteStations { get; set; }

        public void AddFavorite()
        {
            FavoriteStations.Add(CurrentFrequency);
        }

        public void AddFavorite(double station)
        {
            FavoriteStations.Add(station);
        }

        public void RemoveFavorite(double station)
        {
            Console.WriteLine("Man, this is better!");
            FavoriteStations.Remove(station);
        }
    }
}