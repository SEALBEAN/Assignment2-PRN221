using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Repository;

namespace RazorPage.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public InputModel Input { get; set;}

        public class InputModel
        {
            [Required(ErrorMessage = "Can not empty")]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required(ErrorMessage = "Can not empty")]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }
        }

        IConfiguration _configuration;
        ICustomerRepository _customerRepository = new CustomerRepository();

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var account = _customerRepository.GetCustomers().Where(x => x.Password == Input.Password && x.Email == Input.Email).FirstOrDefault();
            bool isAdmin = checkAdmin(Input.Email, Input.Password);
            if (account == null && !isAdmin)
            {
                ViewData["Message"] = "Invalid username or password";
                return Page();
            }
            else if (isAdmin)
            {
                HttpContext.Session.SetString("role", "admin");
                HttpContext.Session.SetString("name", account.CustomerName);
            }
            else
            {
                HttpContext.Session.SetString("role", "customer");
                HttpContext.Session.SetString("name", account.CustomerName);
            }
            HttpContext.Session.SetString("email", Input.Email);
            return RedirectToPage("/MainPage");
        }

        private bool checkAdmin(string email, string password)
        {
            bool isAdmin = false;
            _configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json", true, true).Build();
            if (_configuration["admin:email"] == email && _configuration["admin:password"] == password)
            {
                isAdmin = true;
            }
            return isAdmin;
        }
    }


}
