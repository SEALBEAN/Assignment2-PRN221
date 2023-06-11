using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Repository;
using System.Linq;
using BusinessObject;

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
            //If flowerId not exist in any order detail, delete flower else update status to 0
            FlowerBouquet flower = flowers.GetFlowers().Where(x => x.FlowerBouquetId == int.Parse(flowerId)).FirstOrDefault();
            IOrderDetailRepository orderDetails = new OrderDetailRepository();
            if (orderDetails.GetOrderDetails().Where(x => x.FlowerBouquetId == int.Parse(flowerId)).Count() > 0)
            {
                flower.FlowerBouquetStatus = 0;
                int status = flowers.UpdateFlower(flower);
                if (status > 0)
                {
                    ViewData["Message"] = "The flower exist in some order can't delete this flower : " + flower.FlowerBouquetName +"\n Change it Status to 0 instead";
                }
                else
                {
                    ViewData["Message"] = "Delete fail";
                }
                return Page();
            }else
            {
                int status = flowers.DeleteFlower(int.Parse(flowerId));
                if (status > 0)
                {
                    ViewData["Message"] = "Delete success flower : " + flower.FlowerBouquetName;
                }
                else
                {
                    ViewData["Message"] = "Delete fail";
                }
                return Page();
            }
        }
    }
}
