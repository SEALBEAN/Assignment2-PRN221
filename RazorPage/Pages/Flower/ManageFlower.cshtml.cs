using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Repository;
using System.Linq;

namespace RazorPage.Pages.Flower
{
    public class ManageFlowerModel : PageModel
    {
        public IActionResult OnPostUpdateFlower(string flowerId)
        {
            HttpContext.Session.SetString("FlowerID", flowerId);

            return RedirectToPage("/Flower/EditFlower");
        }

        public IActionResult OnPostDeleteFlower(string flowerId)
        {
            IFlowerRepository flowers = new FlowerRepository();
            string flowerName = flowers.GetFlowers().Where(x => x.FlowerBouquetId == int.Parse(flowerId)).FirstOrDefault().FlowerBouquetName;
            int status = flowers.DeleteFlower(int.Parse(flowerId));
            if (status > 0)
            {
                ViewData["Message"] = "Delete success customer : " + flowerName;
            }
            else
            {
                ViewData["Message"] = "Delete fail";
            }
            return Page();
        }
    }
}
