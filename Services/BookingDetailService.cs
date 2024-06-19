using BusinessObjects;
using Repositories.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BookingDetailService : IBookingDetailService
    {
        private readonly IBookingDetailRepository bookingDetailRepository;

        public BookingDetailService(IBookingDetailRepository bookingDetailRepository)
        {
            this.bookingDetailRepository = bookingDetailRepository;
        }

        public List<BookingDetail> GetBookingDetails()
        {
            return bookingDetailRepository.GetBookingDetails();
        }

        public List<BookingDetail> GetBookingDetailsByCourtSlotIdAndCourtId(int slotId, int courtId)
        {
            return bookingDetailRepository.GetBookingDetailsByCourtSlotIdAndCourtId(slotId, courtId);
        }
    }
}
