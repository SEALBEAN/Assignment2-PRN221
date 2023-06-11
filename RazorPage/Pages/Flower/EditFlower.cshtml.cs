using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Repository;
using System;
using System.Linq;

namespace RazorPage.Pages.Flower
{
    public class EditFlowerModel : PageModel
    {
        public IActionResult OnPostUpdateFlower()
        {
            //get the flower ID from the session
            string flowerId = HttpContext.Session.GetString("FlowerID");

            // Get the flower from the repository
            IFlowerRepository flowers = new FlowerRepository();
            var flower = flowers.GetFlowers().Where(x => x.FlowerBouquetId == int.Parse(flowerId)).FirstOrDefault();

            // Update the flower from the form data

            string a = Request.Form["categoryId"];
            flower.CategoryId = int.Parse(Request.Form["categoryId"]);
            flower.FlowerBouquetName = Request.Form["flowerName"];
            flower.Description = Request.Form["description"];
            flower.UnitPrice = Decimal.Parse( Request.Form["unitPrice"]);
            flower.UnitsInStock = int.Parse(Request.Form["unitInStock"]);
            flower.FlowerBouquetStatus = byte.Parse(Request.Form["flowerBouquetStatus"]);
            flower.SupplierId = int.Parse(Request.Form["supplierId"]);


            // Store the customer in the repository
            int status = flowers.UpdateFlower(flower);

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
    }
}
