using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AbbyWeb.Pages
{
    public class NewPageModel : PageModel
    {

        private readonly ILogger<PrivacyModel> _logger;

        public NewPageModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }


        public void OnGet()
        {
        }
    }
}
