using System;
using UltiTourneysApp.Enums;

namespace UltiTourneysApp.Classes
{
    public class Team
    {
        public int TeamID { get; set; }
        public string Name { get; set; }
        public Division Division { get; set; }

        public List<Player> Roster { get; set; }
    }
}