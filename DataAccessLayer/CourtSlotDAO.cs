using BusinessObjects;
using DataAccessLayer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CourtSlotDAO
    {
        public static List<CourtSlot> GetCourtSlots()
        {
            var courtSlots = new List<CourtSlot>();
            try
            {
                using var dbContext = new BBMSDbContext();
                courtSlots = dbContext.CourtSlots.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return courtSlots;
        }

        public static CourtSlot? GetCourtById(int id)
        {
            using var dbContext = new BBMSDbContext();
            return dbContext.CourtSlots.FirstOrDefault(b => b.Id == id);
        }

        public static bool CreateCourtSlot(CourtSlot courtSlot)
        {
            try
            {
                using var dbContext = new BBMSDbContext();
                dbContext.Add(courtSlot);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static bool UpdateCourtSlot(CourtSlot courtSlot)
        {
            try
            {
                using var dbContext = new BBMSDbContext();
                dbContext.Entry(courtSlot).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
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
