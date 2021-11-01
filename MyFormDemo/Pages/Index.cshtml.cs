using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyFormDemo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        [BindProperty]
        public IList<string> Colors { get; set; }

        public IActionResult OnPost()
        {
            TempData["colors"]= Colors;
            return RedirectToPage("./result");
        }
    }
}