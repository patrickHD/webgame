using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using webgame.Data;
using webgame.Models;

namespace webgame.Pages.Admin.HighScores
{
    public class CreateModel : PageModel
    {
        private readonly webgame.Data.webgameContext _context;

        public CreateModel(webgame.Data.webgameContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public HighScore HighScore { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.HighScore.Add(HighScore);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
