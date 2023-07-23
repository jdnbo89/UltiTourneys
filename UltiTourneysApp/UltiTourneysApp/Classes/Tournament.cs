using System;
namespace UltiTourneysApp.Classes
{
    public class Tournament
    {
        public int tournamentID { get; private set; }
        public string name { get; private set; }
        public DateTime startDate { get; private set; }
        public DateTime endDate { get; private set; }

        public string? city { get; private set; }    // TODO: update location to a location-based class
        public string? state { get; private set; }   // TODO: update location to a location-based class
        public string? country { get; private set; } // TODO: update location to a location-based class

        public List<Team> teams { get; private set; }

        public Tournament (string name, DateTime startDate, DateTime endDate)
        {
            this.name = name;
            this.startDate = startDate;
            this.endDate = endDate;

            this.teams = new List<Team>();
        }
    }
}

