using AoPInterceptionAndFacility.Model;
using System.Collections.Generic;

namespace AoPInterceptionAndFacility.Service
{
    public interface ICategoryService
    {
        Category LoadCategory();
        List<Category> ListCategory();
        string GetCategoryNameById(int categoryId);
        int GetCategoryId(Category category);
    }
}
