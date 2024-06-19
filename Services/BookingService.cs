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
    public class BookingService : IBookingService
    {
        private readonly IBookingReppository bookingReppository;
        public BookingService(IBookingReppository bookingReppository)
        {
            this.bookingReppository = bookingReppository;
        }
        public bool CreateBooking(Booking booking)
        {
            return bookingReppository.CreateBooking(booking);
        }

        public Booking? GetBookingByCourtId(int id)
        {
            return bookingReppository.GetBookingByCourtId(id);
        }

        public Booking? GetBookingById(int id)
        {
            return bookingReppository.GetBookingById(id);
        }

        public List<Booking> GetBookings()
        {
            return bookingReppository.GetBookings();
        }

        public bool UpdateBooking(Booking booking)
        {
            return bookingReppository.UpdateBooking(booking);   
        }
    }
}
