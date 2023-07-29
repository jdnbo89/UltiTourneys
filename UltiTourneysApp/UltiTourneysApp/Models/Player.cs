using System;
using System.ComponentModel.DataAnnotations;

namespace UltiTourneysApp.Models
{
    public class Player
    {
        public int PlayerID { get; set; }
        public string Name { get; set; }

        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "Please enter a valid e-mail address")]
        public string Email { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
    }
}

