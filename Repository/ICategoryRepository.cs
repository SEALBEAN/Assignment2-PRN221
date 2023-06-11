using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetCategories();
        Category GetCategoryByID(int categoryID);
        int InsertCategory(Category category);
        int DeleteCategory(int categoryID);
        int UpdateCategory(Category category);
    }
}
