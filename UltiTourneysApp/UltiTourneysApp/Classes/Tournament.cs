using System;
namespace UltiTourneysApp.Classes
{
    public class Tournament
    {
        public int tournamentID { get; private set; }
        public string name { get; private set; }
        public DateTime date { get; private set; }

        public string? city { get; private set; }    // TODO: update location to a location-based class
        public string? state { get; private set; }   // TODO: update location to a location-based class
        public string? country { get; private set; } // TODO: update location to a location-based class

        public List<Team> teams { get; private set; }

        public Tournament (string name, DateTime date)
        {
            this.name = name;
            this.date = date;

            this.teams = new List<Team>();
        }
    }
}

