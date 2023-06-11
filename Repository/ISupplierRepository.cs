using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface ISupplierRepository
    {
        IEnumerable<Supplier> GetSuppliers();
        Supplier GetSupplierByID(int supplierID);
        int InsertSupplier(Supplier supplier);
        int DeleteSupplier(int supplierID);
        int UpdateSupplier(Supplier supplier);
    }
}
