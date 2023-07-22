using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using UltiTourneysApp.Classes;
using UltiTourneysApp.Data;

namespace UltiTourneysApp.Pages.Tournaments
{
    public class IndexModel : PageModel
    {
        private readonly UltiTourneysApp.Data.TournamentDBContext _context;

        public IndexModel(UltiTourneysApp.Data.TournamentDBContext context)
        {
            _context = context;
        }

        public IList<Tournament> Tournament { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Tournament != null)
            {
                Tournament = await _context.Tournament.ToListAsync();
            }
        }
    }
}
