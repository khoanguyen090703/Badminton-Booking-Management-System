using BusinessObjects;
using DataAccessLayer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class BookingTypeDAO
    {
        public static List<BookingType> GetBookingTypes()
        {
            var bookingTypes = new List<BookingType>();
            try
            {
                using var dbContext = new BBMSDbContext();
                bookingTypes = dbContext.BookingTypes.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return bookingTypes;
        }

        public static BookingType? GetBookingTypeById(int id)
        {
            using var dbContext = new BBMSDbContext();
            return dbContext.BookingTypes.FirstOrDefault(bt => bt.Id == id);
        }

        public static bool CreateBookingType(BookingType bookingType)
        {
            try
            {
                using var dbContext = new BBMSDbContext();
                dbContext.Add(bookingType);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                //return false;
                throw new Exception(ex.Message);
            }
        }

        public static bool UpdateBookingType(BookingType bookingType)
        {
            try
            {
                using var dbContext = new BBMSDbContext();
                dbContext.Entry(bookingType).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                //return false;
                throw new Exception(ex.Message);
            }
        }
    }
}
