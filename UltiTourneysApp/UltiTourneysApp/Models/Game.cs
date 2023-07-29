using System;

namespace UltiTourneysApp.Models
{
    public class Game
    {
        public int GameId { get; set; }

        public int TeamId1 { get; set; }
        public int TeamId2 { get; set; }

        public int TeamScore1 { get; set; }
        public int TeamScore2 { get; set; }
    }
}