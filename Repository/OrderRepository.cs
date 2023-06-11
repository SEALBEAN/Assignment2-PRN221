using BusinessObject;
using DataAcess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class OrderRepository : IOrderRepository
    {
        public int DeleteOrder(int orderId)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetOrders()
        {
            return OrderDAO.GetOrders();
        }

        public int InsertOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public int UpdateOrder(Order order)
        {
            return OrderDAO.UpdateOrder(order);
        }
    }
}
