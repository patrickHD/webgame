using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace webgame.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
           
        }

        [HttpGet]
        public async Task<IActionResult> OnGetTestTask()
        {
            _ = User; var x = User.FindFirst(System.Security.Claims.ClaimTypes.Email); var y = User.FindAll(""); var z = User.ToString(); var i = HttpContext.User;
            int xx = 2;
            return new JsonResult(new int[] { 4, 5, 6 });
        }
    }
}
