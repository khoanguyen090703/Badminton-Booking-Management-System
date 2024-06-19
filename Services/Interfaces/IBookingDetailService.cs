using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IBookingDetailService
    {
        List<BookingDetail> GetBookingDetailsByCourtSlotIdAndCourtId(int slotId, int courtId);
        List<BookingDetail> GetBookingDetails();
    }
}
