using BusinessObjects;
using DataAccessLayer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CustomerDAO
    {
        public static List<Customer> GetCustomers()
        {
            var customers = new List<Customer>();
            try
            {
                using var dbContext = new BBMSDbContext();
                customers = dbContext.Customers.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return customers;
        }

        public static Customer? GetCustomerById(int id)
        {
            using var dbContext = new BBMSDbContext();
            return dbContext.Customers.FirstOrDefault(b => b.Id == id);
        }

        public static bool CreateCustomer(Customer customer)
        {
            try
            {
                using var dbContext = new BBMSDbContext();
                dbContext.Add(customer);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static bool UpdateCustomer(Customer customer)
        {
            try
            {
                using var dbContext = new BBMSDbContext();
                dbContext.Entry(customer).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
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
