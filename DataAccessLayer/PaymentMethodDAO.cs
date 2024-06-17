using BusinessObjects;
using DataAccessLayer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class PaymentMethodDAO
    {
        public static List<PaymentMethod> GetPaymentMethods()
        {
            var paymentMethods = new List<PaymentMethod>();
            try
            {
                using var dbContext = new BBMSDbContext();
                paymentMethods = dbContext.PaymentMethods.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return paymentMethods;
        }

        public static PaymentMethod? GetPaymentMethodById(int id)
        {
            using var dbContext = new BBMSDbContext();
            return dbContext.PaymentMethods.FirstOrDefault(b => b.Id == id);
        }

        public static bool CreatePaymentMethod(PaymentMethod paymentMethod)
        {
            try
            {
                using var dbContext = new BBMSDbContext();
                dbContext.Add(paymentMethod);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static bool UpdatePaymentMethod(PaymentMethod paymentMethod)
        {
            try
            {
                using var dbContext = new BBMSDbContext();
                dbContext.Entry(paymentMethod).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
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
