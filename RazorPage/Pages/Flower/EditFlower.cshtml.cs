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

            if (Request.Form["categoryId"] != "")
            {
                flower.CategoryId = int.Parse(Request.Form["categoryId"]);
            }
            flower.FlowerBouquetName = Request.Form["flowerName"];
            flower.Description = Request.Form["description"];
            flower.UnitPrice = Decimal.Parse(Request.Form["unitPrice"]);
            flower.UnitsInStock = int.Parse(Request.Form["unitInStock"]);
            if (Request.Form["flowerBouquetStatus"] == "")
            {
                ViewData["Status"] = "Status must have value";
                return Page();
            }
            if (byte.Parse(Request.Form["flowerBouquetStatus"]) != 0 && byte.Parse(Request.Form["flowerBouquetStatus"]) != 1)
            {
                ViewData["Status"] = "Status must be 0 or 1";
                return Page();
            }
            flower.FlowerBouquetStatus = byte.Parse(Request.Form["flowerBouquetStatus"]);
            if (Request.Form["supplierId"] != "")
            {
                flower.SupplierId = int.Parse(Request.Form["supplierId"]);
            }

            if (flower.UnitPrice <= 0)
            {
                ViewData["UnitPrice"] = "UnitPrice must > 0";
                return Page();
            }
            if (flower.UnitsInStock <= 0)
            {
                ViewData["UnitInStock"] = "UnitsInStock must > 0";
                return Page();
            }


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
