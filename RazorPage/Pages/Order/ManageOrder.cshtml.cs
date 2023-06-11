using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Repository;
using System.Linq;

namespace RazorPage.Pages.Order
{
    public class ManageOrderModel : PageModel
    {
        public IActionResult OnPostUpdateOrder(string orderId)
        {
            HttpContext.Session.SetString("OrderID", orderId);

            return RedirectToPage("/Order/EditOrder");
        }

        public IActionResult OnPostDeleteOrder(string orderId)
        {
            IOrderRepository orders = new OrderRepository();
            BusinessObject.Order order = orders.GetOrders().Where(x => x.OrderId == int.Parse(orderId)).FirstOrDefault();
            order.OrderStatus = "Deleted";
            int status = orders.UpdateOrder(order);

            if (status > 0)
            {
                ViewData["Message"] = "Update order to deleted";
            }
            else
            {
                ViewData["Message"] = "Delete fail";
            }
            return Page();
        }
    }
}
