using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using UltiTourneysApp.Models;
using UltiTourneysApp.Data;

namespace UltiTourneysApp.Pages.Games
{
    public class IndexModel : PageModel
    {
        private readonly UltiTourneysApp.Data.UltiTourneysDBContext _context;

        public IndexModel(UltiTourneysApp.Data.UltiTourneysDBContext context)
        {
            _context = context;
        }

        public IList<Game> Game { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Game != null)
            {
                Game = await _context.Game.ToListAsync();
            }
        }
    }
}
