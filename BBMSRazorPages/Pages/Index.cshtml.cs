using BusinessObjects;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Services.Interfaces;

namespace BBMSRazorPages.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ICourtSlotService courtSlotService;
        public List<CourtSlot> CourtSlots { get; set; }

        public IndexModel(ILogger<IndexModel> logger, ICourtSlotService courtSlotService)
        {
            _logger = logger;
            this.courtSlotService = courtSlotService;
        }

        public void OnGet()
        {
            CourtSlots = courtSlotService.GetCourtSlots();
        }
    }
}
