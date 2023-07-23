using System;

namespace UltiTourneysApp.Classes
{
    public class Game
    {
        public int GameId { get; private set; }

        public int TeamId1 { get; private set; }
        public int TeamId2 { get; private set; }

        public int TeamScore1 { get; private set; }
        public int TeamScore2 { get; private set; }

        public Game()
        {

        }
    }
}

