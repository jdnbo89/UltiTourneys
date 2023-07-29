using System;
using UltiTourneysApp.Enums;

namespace UltiTourneysApp.Models
{
    public class Team
    {
        public int TeamID { get; set; }
        public string Name { get; set; }
        public Division Division { get; set; }

        public List<Player> Roster { get; set; }

        public Team()
        {
            Roster = new List<Player>();
        }
    }
}