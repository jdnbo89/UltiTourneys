using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using UltiTourneysApp.Classes;
using UltiTourneysApp.Data;

namespace UltiTourneysApp.Pages.Teams
{
    public class DetailsModel : PageModel
    {
        private readonly UltiTourneysApp.Data.UltiTourneysDBContext _context;

        public DetailsModel(UltiTourneysApp.Data.UltiTourneysDBContext context)
        {
            _context = context;
        }

      public Team Team { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Team == null)
            {
                return NotFound();
            }

            var team = await _context.Team.FirstOrDefaultAsync(m => m.TeamID == id);
            if (team == null)
            {
                return NotFound();
            }
            else 
            {
                Team = team;
            }
            return Page();
        }
    }
}
