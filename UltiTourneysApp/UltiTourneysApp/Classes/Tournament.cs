using System;
using System.ComponentModel.DataAnnotations;

namespace UltiTourneysApp.Classes
{
    public class Tournament
    {
        public int TournamentID { get; private set; }

        [Display(Name = "Tournament")]
        public string Name { get; private set; }

        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; private set; }

        [Display(Name = "End Date")]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; private set; }

        public string? City { get; private set; }    // TODO: update location to a location-based class
        public string? State { get; private set; }   // TODO: update location to a location-based class
        public string? Country { get; private set; } // TODO: update location to a location-based class

        public List<Team> Teams { get; private set; }
    }
}

