using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IOrderRepository
    {
        List<Order> GetOrders();
        int InsertOrder(Order order);
        int UpdateOrder(Order order);
        int DeleteOrder(int orderId);
    }
}
