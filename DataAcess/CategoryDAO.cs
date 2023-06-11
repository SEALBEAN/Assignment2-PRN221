using BusinessObject;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess
{
    public class CategoryDAO
    {
        //Create CategoryDAO singleton
        private static CategoryDAO instance = null;
        private static readonly object instanceLock = new object();
        public static CategoryDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CategoryDAO();
                    }
                    return instance;
                }
            }
        }
        public static Category GetCategoryById(int id)
        {
            Category category;
            try
            {
                var dbContext = new FUFlowerBouquetManagementContext();
                category = dbContext.Categories.Where(x => x.CategoryId == id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return category;
        }
    }
}
