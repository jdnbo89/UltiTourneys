using System;
using UltiTourneysApp.Structs;

namespace UltiTourneysApp.Classes
{
    public class Game
    {
        public int gameId { get; private set; }

        public int teamId1 { get; private set; }
        public int teamId2 { get; private set; }

        public int teamScore1 { get; private set; }
        public int teamScore2 { get; private set; }

        public Game()
        {

        }
    }
}

