using BusinessObjects;
using DataAccessLayer.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class PriceDAO
    {
        public static List<Price> GetPrices()
        {
            var prices = new List<Price>();
            try
            {
                using var dbContext = new BBMSDbContext();
                prices = dbContext.Prices.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return prices;
        }

        public static Price? GetPriceById(int id)
        {
            using var dbContext = new BBMSDbContext();
            return dbContext.Prices.FirstOrDefault(b => b.Id == id);
        }

        public static bool CreatePrice(Price price)
        {
            try
            {
                using var dbContext = new BBMSDbContext();
                dbContext.Add(price);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static bool UpdatePrice(Price price)
        {
            try
            {
                using var dbContext = new BBMSDbContext();
                dbContext.Entry(price).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
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
