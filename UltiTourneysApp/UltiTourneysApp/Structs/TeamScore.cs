using System;
using UltiTourneysApp.Classes;

namespace UltiTourneysApp.Structs
{
    public struct TeamScore
    {
        public Team team { get; private set; }
        public int? score { get; private set; }

        public TeamScore (Team team)
        {
            this.team = team;
        }
    }
}

