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
    public class ManageCustomerModel : PageModel
    {
        

        public IActionResult OnPostUpdateCustomer(string customerId)
        {

            // Store the customer in TempData
            HttpContext.Session.SetString("CustomerID", customerId);

            // Redirect to the "/EditCustomer" page
            return RedirectToPage("/EditCustomer");
        }

        public IActionResult OnPostDeleteCustomer(string customerId)
        {
            ICustomerRepository customers = new CustomerRepository();
            string customerName = customers.GetCustomers().Where(x => x.CustomerId == int.Parse(customerId)).FirstOrDefault().CustomerName;
            int status = customers.DeleteCustomer(int.Parse(customerId));
            if (status > 0)
            {
                ViewData["Message"] = "Delete success customer : " + customerName;
            }
            else
            {
                ViewData["Message"] = "Delete fail";
            }
            return Page();
        }
        public void OnGet()
        {
        }
    }
}
