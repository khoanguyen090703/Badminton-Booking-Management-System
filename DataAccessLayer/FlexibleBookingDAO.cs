using BusinessObjects;
using DataAccessLayer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class FlexibleBookingDAO
    {
        public static List<FlexibleBooking> GetFlexibleBookings()
        {
            var flexibleBookings = new List<FlexibleBooking>();
            try
            {
                using var dbContext = new BBMSDbContext();
                flexibleBookings = dbContext.FlexibleBookings.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return flexibleBookings;
        }

        public static FlexibleBooking? GetFlexibleBookingById(int id)
        {
            using var dbContext = new BBMSDbContext();
            return dbContext.FlexibleBookings.FirstOrDefault(b => b.Id == id);
        }

        public static bool CreateFlexibleBooking(FlexibleBooking flexibleBooking)
        {
            try
            {
                using var dbContext = new BBMSDbContext();
                dbContext.Add(flexibleBooking);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static bool UpdateFlexibleBooking(FlexibleBooking flexibleBooking)
        {
            try
            {
                using var dbContext = new BBMSDbContext();
                dbContext.Entry(flexibleBooking).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
