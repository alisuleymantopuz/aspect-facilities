using AoPInterceptionAndFacility.Model;
using AoPInterceptionAndFacility.Service;
using System;
using System.Collections.Generic;

namespace AoPInterceptionAndFacility.Implementation
{
    public class CategoryService : ICategoryService
    {
        public Category LoadCategory()
        {
            return new Category() { Id = 1, Description = "Hot and soft drinks.", Name = "Beverages" };
        }

        public List<Category> ListCategory()
        {
            return new List<Category>() { new Category() { Id = 1, Description = "Hot and soft drinks.", Name = "Beverages" }, new Category() { Id = 2, Description = "Mixed drinks.", Name = "Coctails" } };
        }

        public string GetCategoryNameById(int categoryId)
        {
            return Guid.NewGuid().ToString().Replace("-", "").ToUpper().Substring(0, 8);
        }

        public int GetCategoryId(Category category)
        {
            return category.Id;
        }
    }
}
