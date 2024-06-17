using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interfaces
{
    public interface ICustomerRepository
    {
        List<Customer> GetCustomers();

        Customer? GetCustomerById(int id);

        bool CreateCustomer(Customer customer);

        bool UpdateCustomer(Customer customer);
    }
}
