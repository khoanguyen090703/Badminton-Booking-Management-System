using BusinessObjects;
using DataAccessLayer;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public bool CreateCustomer(Customer customer)
            => CustomerDAO.CreateCustomer(customer);

        public Customer? GetCustomerById(int id)
            => CustomerDAO.GetCustomerById(id);

        public List<Customer> GetCustomers()
            => CustomerDAO.GetCustomers();

        public bool UpdateCustomer(Customer customer)
            => CustomerDAO.UpdateCustomer(customer);    
    }
}
