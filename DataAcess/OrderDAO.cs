using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess
{
    public class OrderDAO
    {
        private static OrderDAO instance = null;
        private static readonly object instanceLock = new object();
        public static OrderDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDAO();
                    }
                    return instance;
                }
            }
        }
        public static List<Order> GetOrders()
        {
            List<Order> orders;
            try
            {
                var dbContext = new FUFlowerBouquetManagementContext();
                orders = dbContext.Orders.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orders;
        }

        public static int UpdateOrder(Order order)
        {
            int status = 0;
            try
            {
                var dbContext = new FUFlowerBouquetManagementContext();
                var orderUpdate = dbContext.Orders.Where(x => x.OrderId == order.OrderId).FirstOrDefault();
                orderUpdate.OrderStatus = order.OrderStatus;
                status = dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return status;
        }
    }
}
