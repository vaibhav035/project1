
using Infosys.DBFirstCore.DataAccessLayer;
using Infosys.DBFirstCore.DataAccessLayer.Models;
using System;

using System.Collections.Generic;

namespace Infosys.DBFirstCore.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            //QuickKartRepository repository = new QuickKartRepository();
            //byte categoryId = 1;
            //List<Products> lstproducts = repository.GetProductsOnCategoryId(categoryId);
            //if (lstproducts.Count == 0)
            //{
            //    Console.WriteLine("No products available under the category = " + categoryId);
            //}
            //else
            //{
            //    Console.WriteLine("{0,-15}{1,-30}{2,-15}{3,-10}{4}", "ProductId", "ProductName", "CategoryId", "Price", "QuantityAvailable");
            //    Console.WriteLine("---------------------------------------------------------------------------------------");
            //    foreach (var product in lstproducts)
            //    {
            //        Console.WriteLine("{0,-15}{1,-30}{2,-15}{3,-10}{4}", product.ProductId, product.ProductName, product.CategoryId, product.Price, product.QuantityAvailable);
            //    }
            //}
            //QuickKartRepository repository = new QuickKartRepository();
            //bool result = repository.AddCategory("Books");
            //if (result)
            //{
            //    Console.WriteLine("New category added successfully");
            //}
            //else
            //{
            //    Console.WriteLine("Something went wrong. Try again!");
            //}
            QuickKartRepository repository = new QuickKartRepository();
            bool result = repository.UpdateCategory(11, "Stationery");
            if (result)
            {
                Console.WriteLine("Category details updated successfully");
            }
            else
            {
                Console.WriteLine("Something went wrong. Try again!");
            }
        }
    }
}
