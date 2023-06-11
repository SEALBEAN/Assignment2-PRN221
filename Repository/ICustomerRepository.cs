using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace Repository
{
    public interface ICustomerRepository
    {
        int AddCustomer(Customer customer);
        int DeleteCustomer(int customerId);
        IEnumerable<Customer> GetCustomers();
        int UpdateCustomer(Customer customer);
    }
}
