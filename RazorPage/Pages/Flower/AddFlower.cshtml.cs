using BusinessObject;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Repository;
using System;
using System.Linq;

namespace RazorPage.Pages.Flower
{
    public class AddFlowerModel : PageModel
    {
        public IActionResult OnPostAddFlower()
        {
            // Get the flower from the form data
            FlowerBouquet flower = new FlowerBouquet();
            if (Request.Form["categoryId"] != "")
            {
                flower.CategoryId = int.Parse(Request.Form["categoryId"]);
            }
            else
            {
                ViewData["CategoryId"] = "CategoryId must have value";
                return Page();
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

            IFlowerRepository flowers = new FlowerRepository();
            if (flowers.GetFlowers().Where(x => x.FlowerBouquetName == flower.FlowerBouquetName).FirstOrDefault() != null)
            {
                ViewData["Name"] = "Duplicate name";
                return Page();
            }
            int status = flowers.AddFlower(flower);

            //If status >0 return update success to page
            if (status > 0)
            {
                ViewData["Message"] = "Create new Flower successfully";
            }
            else
            {
                ViewData["Message"] = "Create fail";
            }
            return Page();
        }
    }
}
