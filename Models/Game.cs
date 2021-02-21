
using System;

namespace GameStatisticsApp.Models
{
    public class Game
    {
        public string Name { get; set; }
        public double SoldCopies { get; set; }
        public DateTime ReleaseYear { get; set; }
        public string Genre { get; set; }
        public string Company { get; set; }
    }
}