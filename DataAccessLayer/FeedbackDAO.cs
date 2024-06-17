using BusinessObjects;
using DataAccessLayer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class FeedbackDAO
    {
        public static List<Feedback> GetFeedbacks()
        {
            var feedbacks = new List<Feedback>();
            try
            {
                using var dbContext = new BBMSDbContext();
                feedbacks = dbContext.Feedbacks.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return feedbacks;
        }

        public static Feedback? GetFeedbackById(int id)
        {
            using var dbContext = new BBMSDbContext();
            return dbContext.Feedbacks.FirstOrDefault(b => b.Id == id);
        }

        public static bool CreateFeedback(Feedback feedback)
        {
            try
            {
                using var dbContext = new BBMSDbContext();
                dbContext.Add(feedback);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static bool UpdateFeedback(Feedback feedback)
        {
            try
            {
                using var dbContext = new BBMSDbContext();
                dbContext.Entry(feedback).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
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
