using BusinessObjects;
using DataAccessLayer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CourtGroupDAO
    {
        public static List<CourtGroup> GetCourtGroups()
        {
            var courtGroups = new List<CourtGroup>();
            try
            {
                using var dbContext = new BBMSDbContext();
                courtGroups = dbContext.CourtGroups.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return courtGroups;
        }

        public static CourtGroup? GetCourtGroupById(int id)
        {
            using var dbContext = new BBMSDbContext();
            return dbContext.CourtGroups.FirstOrDefault(b => b.Id == id);
        }

        public static bool CreateCourtGroup(CourtGroup courtGroup)
        {
            try
            {
                using var dbContext = new BBMSDbContext();
                dbContext.Add(courtGroup);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static bool UpdateCourtGroup(CourtGroup courtGroup)
        {
            try
            {
                using var dbContext = new BBMSDbContext();
                dbContext.Entry(courtGroup).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
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
