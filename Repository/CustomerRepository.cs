using BusinessObject;
using System;
using System.Collections.Generic;
using DataAcess;

namespace Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        public int AddCustomer(Customer customer)
        {
            return CustomerDAO.Instance.AddCustomer(customer);
        }

        public int DeleteCustomer(int customerId)
        {
            return CustomerDAO.Instance.DeleteCustomer(customerId);
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return CustomerDAO.Instance.Customers();
        }

        public int UpdateCustomer(Customer customer)
        {
            //Update the customer in the database
            return CustomerDAO.Instance.UpdateCustomer(customer);
        }
    }
}
