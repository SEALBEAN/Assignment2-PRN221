using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Repository;
using System.Linq;

namespace RazorPage.Pages.Order
{
    public class EditOrderModel : PageModel
    {
        public IActionResult OnPostUpdateOrder()
        {
            string orderId = HttpContext.Session.GetString("OrderID");

            // Get the flower from the repository
            IOrderRepository orders = new OrderRepository();
            var order = orders.GetOrders().Where(x => x.OrderId == int.Parse(orderId)).FirstOrDefault();
            order.OrderStatus = Request.Form["orderStatus"];

            int status = orders.UpdateOrder(order);

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
