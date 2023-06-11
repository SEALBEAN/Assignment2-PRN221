using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess
{
    public class SupplierDAO
    {
        private static SupplierDAO instance;
        public static SupplierDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new SupplierDAO();
                return instance;
            }
            private set { instance = value; }
        }
        public static SupplierDAO GetInstance()
        {
              if (instance == null)
                instance = new SupplierDAO();
            return instance;
        }

        public static Supplier GetSupplierById(int id)
        {
            Supplier supplier;
            try
            {
                var dbContext = new FUFlowerBouquetManagementContext();
                supplier = dbContext.Suppliers.Where(x => x.SupplierId == id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return supplier;
        }

    }
}
