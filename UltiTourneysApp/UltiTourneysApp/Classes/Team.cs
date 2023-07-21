using System;
using UltiTourneysApp.Enums;

namespace UltiTourneysApp.Classes
{
    public class Team
    {
        public int teamID { get; private set; }
        public string name { get; private set; }
        public Division division { get; private set; }

        public List<Player> roster { get; private set; }

        public Team (string name, Division division)
        {
            this.name = name;
            this.division = division;

            roster = new List<Player>();
        }
    }
}

