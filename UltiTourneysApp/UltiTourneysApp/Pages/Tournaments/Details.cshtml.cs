using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using UltiTourneysApp.Models;
using UltiTourneysApp.Data;

namespace UltiTourneysApp.Pages.Tournaments
{
    public class DetailsModel : PageModel
    {
        private readonly UltiTourneysApp.Data.UltiTourneysDBContext _context;

        public DetailsModel(UltiTourneysApp.Data.UltiTourneysDBContext context)
        {
            _context = context;
        }

      public Tournament Tournament { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Tournament == null)
            {
                return NotFound();
            }

            var tournament = await _context.Tournament.FirstOrDefaultAsync(m => m.TournamentID == id);
            if (tournament == null)
            {
                return NotFound();
            }
            else 
            {
                Tournament = tournament;
            }
            return Page();
        }
    }
}
