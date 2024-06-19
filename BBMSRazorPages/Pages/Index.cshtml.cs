using BusinessObjects;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Services.Interfaces;
using System.Text.Json;

namespace BBMSRazorPages.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ICourtSlotService courtSlotService;
        private readonly ICourtService courtService;
        private readonly IBookingDetailService bookingDetailService;

        public List<CourtSlot> CourtSlots { get; set; }
        public List<Court> Courts { get; set; }
        public List<BookingDetail> BookingDetails { get; set; }

        public User UserSession { get; set; }

        public string Message { get; set; }

        public IndexModel(ILogger<IndexModel> logger, ICourtSlotService courtSlotService, ICourtService courtService, IBookingDetailService bookingDetailService)
        {
            _logger = logger;
            this.courtSlotService = courtSlotService;
            this.courtService = courtService;
            this.bookingDetailService = bookingDetailService;
        }

        public void OnGet()
        {
            CourtSlots = courtSlotService.GetCourtSlots();
            Courts = courtService.GetCourts();
            BookingDetails = bookingDetailService.GetBookingDetails();
            string userSess = HttpContext.Session.GetString("SessionAccount");
            if (userSess != null)
            {
                UserSession = JsonSerializer.Deserialize<User>(userSess);
            }
        }

        //public Booking GetBookingByCourtId(int courtId)
        //{
            
        //}
    }
}
