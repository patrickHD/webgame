using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using webgame.Data;
using webgame.Models;

namespace webgame.Pages.Admin.HighScores
{
    public class DetailsModel : PageModel
    {
        private readonly webgame.Data.webgameContext _context;

        public DetailsModel(webgame.Data.webgameContext context)
        {
            _context = context;
        }

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
    }
}
