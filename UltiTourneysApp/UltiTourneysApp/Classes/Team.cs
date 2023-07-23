using System;
using UltiTourneysApp.Enums;

namespace UltiTourneysApp.Classes
{
    public class Team
    {
        public int TeamID { get; private set; }
        public string Name { get; private set; }
        public Division Division { get; private set; }

        public List<Player> Roster { get; private set; }

        public Team (string name, Division division)
        {
            this.Name = name;
            this.Division = division;

            Roster = new List<Player>();
        }
    }
}

