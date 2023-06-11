using BusinessObject;
using DataAcess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public int DeleteOrderDetail(int orderDetailId)
        {
            throw new NotImplementedException();
        }

        public List<OrderDetail> GetOrderDetails()
        {
            return OrderDetailDAO.GetOrderDetails();
        }

        public int InsertOrderDetail(OrderDetail orderDetail)
        {
            throw new NotImplementedException();
        }

        public int UpdateOrderDetail(OrderDetail orderDetail)
        {
            throw new NotImplementedException();
        }
    }
}
