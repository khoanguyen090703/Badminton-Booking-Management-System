using BusinessObjects;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
<<<<<<< HEAD
using Services.Interfaces;
=======
using System.Text.Json;
>>>>>>> 79e20cdbced95d41b53fdc7f2ed7fc410b978338

namespace BBMSRazorPages.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ICourtSlotService courtSlotService;
        public List<CourtSlot> CourtSlots { get; set; }

<<<<<<< HEAD
        public IndexModel(ILogger<IndexModel> logger, ICourtSlotService courtSlotService)
=======
        public User UserSession { get; set; }

        public string Message { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
>>>>>>> 79e20cdbced95d41b53fdc7f2ed7fc410b978338
        {
            _logger = logger;
            this.courtSlotService = courtSlotService;
        }

        public void OnGet()
        {
<<<<<<< HEAD
            CourtSlots = courtSlotService.GetCourtSlots();
=======
            string userSess = HttpContext.Session.GetString("SessionAccount");
            if (userSess != null)
            {
                UserSession = JsonSerializer.Deserialize<User>(userSess);
            }
>>>>>>> 79e20cdbced95d41b53fdc7f2ed7fc410b978338
        }
    }
}
