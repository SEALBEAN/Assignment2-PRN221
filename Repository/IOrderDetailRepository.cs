﻿using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IOrderDetailRepository
    {
        List<OrderDetail> GetOrderDetails();
        int InsertOrderDetail(OrderDetail orderDetail);
        int UpdateOrderDetail(OrderDetail orderDetail);
        int DeleteOrderDetail(int orderDetailId);
    }
}
