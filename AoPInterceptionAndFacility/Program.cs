using AoPInterceptionAndFacility.Container;
using AoPInterceptionAndFacility.Model;
using AoPInterceptionAndFacility.Service;
using System;

namespace AoPInterceptionAndFacility
{
    class Program
    {
        static void Main(string[] args)
        {

            Bootstrapper.Initialize();


            ICategoryService categoryService = Bootstrapper.Container.Resolve<ICategoryService>();

            categoryService.GetCategoryId(new Category() {Id = 2, Name = "Test"});

            categoryService.GetCategoryNameById(1);

            categoryService.ListCategory();

            categoryService.LoadCategory();


            Console.ReadKey();
        }
    }
}
