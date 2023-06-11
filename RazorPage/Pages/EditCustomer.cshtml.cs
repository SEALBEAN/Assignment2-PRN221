using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Repository;

namespace RazorPage.Pages
{
    public class EditCustomerModel : PageModel
    {
        //Update the customer from the form data on OnPost
        public IActionResult OnPost()
        {
            // Get the customer ID from the session
            string customerId = HttpContext.Session.GetString("CustomerID");

            // Get the customer from the repository
            ICustomerRepository customers = new CustomerRepository();
            var customer = customers.GetCustomers().Where(x=> x.CustomerId == int.Parse(customerId)).FirstOrDefault();

            // Update the customer from the form data
            customer.CustomerName = Request.Form["customerName"];
            customer.Email = Request.Form["email"];
            customer.City = Request.Form["City"];
            customer.Birthday = DateTime.Parse(Request.Form["Birthday"]);
            customer.Country = Request.Form["Country"];

            // Store the customer in the repository
            int status = customers.UpdateCustomer(customer);

            //If status >0 return update success to page
            if (status > 0)
            {
                ViewData["Message"] = "Update success";
            }
            else
            {
                ViewData["Message"] = "Update fail";
            }

            // Return to page
            return Page();
        }
        public void OnGet()
        {
        }
    }
}
