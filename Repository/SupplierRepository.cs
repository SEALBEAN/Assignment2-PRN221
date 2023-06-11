using BusinessObject;
using DataAcess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class SupplierRepository : ISupplierRepository
    {
        public int DeleteSupplier(int supplierID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Supplier> GetSuppliers()
        {
            return SupplierDAO.GetSuppliers();
        }

        public Supplier GetSupplierByID(int supplierID)
        {
            return SupplierDAO.GetSupplierById(supplierID);
        }

        public int InsertSupplier(Supplier supplier)
        {
            throw new NotImplementedException();
        }

        public int UpdateSupplier(Supplier supplier)
        {
            throw new NotImplementedException();
        }
    }
}
