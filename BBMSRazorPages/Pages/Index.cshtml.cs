using BusinessObjects;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;

namespace BBMSRazorPages.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public User UserSession { get; set; }

        public string Message { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            string userSess = HttpContext.Session.GetString("SessionAccount");
            if (userSess != null)
            {
                UserSession = JsonSerializer.Deserialize<User>(userSess);
            }
        }
    }
}
