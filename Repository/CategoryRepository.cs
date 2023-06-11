using BusinessObject;
using DataAcess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        public int DeleteCategory(int categoryID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> GetCategories()
        {
            return CategoryDAO.GetCategories();
        }

        public Category GetCategoryByID(int categoryID)
        {
            return CategoryDAO.GetCategoryById(categoryID);
        }

        public int InsertCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public int UpdateCategory(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
