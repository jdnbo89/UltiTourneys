using System;
using System.ComponentModel.DataAnnotations;

namespace UltiTourneysApp.Classes
{
    public class Tournament
    {
        public int TournamentID { get; set; }

        [Display(Name = "Tournament")]
        [Required(ErrorMessage = "Please enter the tournament name.")]
        public string Name { get; set; }

        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Display(Name = "End Date")]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        public string? City { get; set; }    // TODO: update location to a location-based class
        public string? State { get; set; }   // TODO: update location to a location-based class
        public string? Country { get; set; } // TODO: update location to a location-based class

        public List<Team> Teams { get; set; }

        public Tournament()
        {
            Teams = new List<Team>();
        }
    }
}

