using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Repository;
using System;
using System.Linq;

namespace RazorPage.Pages.Customers
{
    public class AddCustomerModel : PageModel
    {

        public IActionResult OnPostAddCustomer()
        {

            BusinessObject.Customer customer = new BusinessObject.Customer();
            customer.CustomerName = Request.Form["customerName"];
            customer.Email = Request.Form["email"];
            customer.Password = Request.Form["password"];
            customer.City = Request.Form["City"];
            if (Request.Form["Birthday"] != "")
            {
                customer.Birthday = DateTime.Parse(Request.Form["Birthday"]);
            }
            customer.Country = Request.Form["Country"];

            ICustomerRepository customers = new CustomerRepository();
            if (customers.GetCustomers().Where(x => x.Email == customer.Email).FirstOrDefault() != null)
            {
                ViewData["Duplicate"] = "Duplicate email";
                return Page();
            }
            int status = customers.AddCustomer(customer);

            //If status >0 return update success to page
            if (status > 0)
            {
                ViewData["Message"] = "Create new Account successfully";
            }
            else
            {
                ViewData["Message"] = "Create fail";
            }

            // Return to page
            return Page();
        }
    }
}
