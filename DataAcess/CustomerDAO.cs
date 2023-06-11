using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAcess
{
    public class CustomerDAO
    {
        private static CustomerDAO instance = null;
        private static readonly object instanceLock = new object();

        public static CustomerDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CustomerDAO();
                    }
                    return instance;
                }
            }
        }
        public List<Customer> Customers(string name = null, string id = null, string email = null)
        {
            List<Customer> customers;
            try
            {
                var dbContext = new FUFlowerBouquetManagementContext();
                customers = dbContext.Customers.ToList();
                if (!string.IsNullOrEmpty(name))
                {
                    customers = customers.Where(x => x.CustomerName.Contains(name)).ToList();
                }
                if (!string.IsNullOrEmpty(id))
                {
                    customers = customers.Where(x => x.CustomerId == int.Parse(id)).ToList();
                }
                if (!string.IsNullOrEmpty(email))
                {
                    customers = customers.Where(x => x.Email.Contains(email)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return customers;
        }

        public int UpdateCustomer(Customer customer)
        {
            try
            {
                var dbContext = new FUFlowerBouquetManagementContext();
                var customerToUpdate = dbContext.Customers.Where(x => x.CustomerId == customer.CustomerId).FirstOrDefault();
                int status = 0;
                if (customerToUpdate != null)
                {
                    customerToUpdate.CustomerName = customer.CustomerName;
                    customerToUpdate.Email = customer.Email;
                    customerToUpdate.City = customer.City;
                    customerToUpdate.Birthday = customer.Birthday;
                    customerToUpdate.Country = customer.Country;
                    status =  dbContext.SaveChanges();
                }
                return status;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int DeleteCustomer(int customerId)
        {
            try
            {
                var dbContext = new FUFlowerBouquetManagementContext();
                var customerToDelete = dbContext.Customers.Where(x => x.CustomerId == customerId).FirstOrDefault();
                int status = 0;
                if (customerToDelete != null)
                {
                    dbContext.Customers.Remove(customerToDelete);
                    status = dbContext.SaveChanges();
                }
                return status;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }   
        }

        public int AddCustomer(Customer customer)
        {
            try
            {
                var dbContext = new FUFlowerBouquetManagementContext();
                var nextId = dbContext.Customers.OrderByDescending(x => x.CustomerId).FirstOrDefault().CustomerId;
                int status = 0;
                customer.CustomerId = nextId + 1;
                dbContext.Customers.Add(customer);
                status = dbContext.SaveChanges();
                return status;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
