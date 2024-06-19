using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interfaces
{
    public interface IBookingDetailRepository
    {
        List<BookingDetail> GetBookingDetailsByCourtSlotIdAndCourtId(int slotId, int courtId);
        List<BookingDetail> GetBookingDetails();
    }
}
