using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using UltiTourneysApp.Models;
using UltiTourneysApp.Data;

namespace UltiTourneysApp.Pages.Players
{
    public class DeleteModel : PageModel
    {
        private readonly UltiTourneysApp.Data.UltiTourneysDBContext _context;

        public DeleteModel(UltiTourneysApp.Data.UltiTourneysDBContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Player Player { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Player == null)
            {
                return NotFound();
            }

            var player = await _context.Player.FirstOrDefaultAsync(m => m.PlayerID == id);

            if (player == null)
            {
                return NotFound();
            }
            else 
            {
                Player = player;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Player == null)
            {
                return NotFound();
            }
            var player = await _context.Player.FindAsync(id);

            if (player != null)
            {
                Player = player;
                _context.Player.Remove(Player);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
