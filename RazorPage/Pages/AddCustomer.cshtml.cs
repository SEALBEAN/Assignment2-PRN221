using BusinessObject;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Repository;
using System;
using System.Linq;

namespace RazorPage.Pages
{
    public class AddCustomerModel : PageModel
    {
        // Add the customer to the repository
        public IActionResult OnPostAddCustomer()
        {
            // Get the customer from the form data
            Customer customer = new Customer();
            customer.CustomerName = Request.Form["customerName"];
            customer.Email = Request.Form["email"];
            customer.Password = Request.Form["password"];
            customer.City = Request.Form["City"];
            if (Request.Form["Birthday"] != "")
            {
                customer.Birthday = DateTime.Parse(Request.Form["Birthday"]);
            }
            customer.Country = Request.Form["Country"];
            //Check is there any duplicate email if yes alert duplicate email and not add to database
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
