using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess
{
    public class OrderDetailDAO
    {
        //create singleton pattern
        private static OrderDetailDAO instance = null;
        private static readonly object instanceLock = new object();
        public static OrderDetailDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDetailDAO();
                    }
                    return instance;
                }
            }
        }
        //get all order details
        public static List<OrderDetail> GetOrderDetails()
        {
            List<OrderDetail> orderDetails;
            try
            {
                var dbContext = new FUFlowerBouquetManagementContext();
                orderDetails = dbContext.OrderDetails.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orderDetails;
        }
    }
}
