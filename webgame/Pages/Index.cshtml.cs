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

        public static void OnGet()
        {
           
        }

        public async Task<IActionResult> OnGetTestTask()
        {
            _ = User;
            await Task.Delay(1);
            return new JsonResult(new int[] { 4, 5, 6 });
        }
    }
}
