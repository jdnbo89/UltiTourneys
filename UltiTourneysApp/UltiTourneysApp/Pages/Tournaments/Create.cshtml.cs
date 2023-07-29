using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using UltiTourneysApp.Models;
using UltiTourneysApp.Data;

namespace UltiTourneysApp.Pages.Tournaments
{
    public class CreateModel : PageModel
    {
        private readonly UltiTourneysApp.Data.UltiTourneysDBContext _context;

        public CreateModel(UltiTourneysApp.Data.UltiTourneysDBContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Tournament Tournament { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.Tournament == null || Tournament == null)
            {
                return Page();
            }

            _context.Tournament.Add(Tournament);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
