using OOP1;
using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ID = 1;
            product1.CategoryID = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { ID = 2, CategoryID = 5, ProductName = "Kalem", UnitsInStock = 5, UnitPrice = 35 };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
        }
    }
}