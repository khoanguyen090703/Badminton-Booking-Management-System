using BusinessObjects;
using DataAccessLayer;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class BookingDetailRepository : IBookingDetailRepository
    {
        public List<BookingDetail> GetBookingDetails()
            => BookingDetailDAO.GetBookingDetails();

        public List<BookingDetail> GetBookingDetailsByCourtSlotIdAndCourtId(int slotId, int courtId)
            => BookingDetailDAO.GetBookingDetailsByCourtSlotIdAndCourtId(slotId, courtId);
    }
}
