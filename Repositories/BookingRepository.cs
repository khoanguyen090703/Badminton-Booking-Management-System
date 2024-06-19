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
    public class BookingRepository : IBookingReppository
    {
        public bool CreateBooking(Booking booking)
            => BookingDAO.CreateBooking(booking);

        public Booking? GetBookingByCourtId(int id)
            => BookingDAO.GetBookingByCourtId(id);

        public Booking? GetBookingById(int id)
            => BookingDAO.GetBookingById(id);

        public List<Booking> GetBookings()
            => BookingDAO.GetBookings();

        public bool UpdateBooking(Booking booking)
            => BookingDAO.UpdateBooking(booking);
    }
}
