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
    public class IndexModel : PageModel
    {
        private readonly webgame.Data.webgameContext _context;

        public IndexModel(webgame.Data.webgameContext context)
        {
            _context = context;
        }

        public IList<HighScore> HighScore { get;set; }

        public async Task OnGetAsync()
        {
            HighScore = await _context.HighScore.ToListAsync();
        }
    }
}
