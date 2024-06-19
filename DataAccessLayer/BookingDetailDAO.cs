using BusinessObjects;
using DataAccessLayer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class BookingDetailDAO
    {
        public static List<BookingDetail> GetBookingDetailsByCourtSlotIdAndCourtId(int slotId, int courtId)
        {
            var bookingDetails = new List<BookingDetail>();
            try
            {
                using var dbContext = new BBMSDbContext();
                bookingDetails = dbContext.BookingDetails.Where(bd => bd.CourtSlotId == slotId && bd.Booking.Court.Id == courtId).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return bookingDetails;
        }

        public static List<BookingDetail> GetBookingDetails()
        {
            var bookingDetails = new List<BookingDetail>();
            try
            {
                using var dbContext = new BBMSDbContext();
                bookingDetails = dbContext.BookingDetails.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return bookingDetails;
        }
    }
}
