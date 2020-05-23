using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using webgame.Data;
using webgame.Models;

namespace webgame.Pages.Admin.HighScores
{
    public class EditModel : PageModel
    {
        private readonly webgame.Data.webgameContext _context;

        public EditModel(webgame.Data.webgameContext context)
        {
            _context = context;
        }

        [BindProperty]
        public HighScore HighScore { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            HighScore = await _context.HighScore.FirstOrDefaultAsync(m => m.ID == id);

            if (HighScore == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(HighScore).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HighScoreExists(HighScore.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool HighScoreExists(int id)
        {
            return _context.HighScore.Any(e => e.ID == id);
        }
    }
}
