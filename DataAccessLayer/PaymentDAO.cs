using BusinessObjects;
using DataAccessLayer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class PaymentDAO
    {
        public static List<Payment> GetPayments()
        {
            var payments = new List<Payment>();
            try
            {
                using var dbContext = new BBMSDbContext();
                payments = dbContext.Payments.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return payments;
        }

        public static Payment? GetPaymentById(int id)
        {
            using var dbContext = new BBMSDbContext();
            return dbContext.Payments.FirstOrDefault(b => b.Id == id);
        }

        public static bool CreatePayment(Payment payment)
        {
            try
            {
                using var dbContext = new BBMSDbContext();
                dbContext.Add(payment);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static bool UpdatePayment(Payment payment)
        {
            try
            {
                using var dbContext = new BBMSDbContext();
                dbContext.Entry(payment).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
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
