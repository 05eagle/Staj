using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProductManager productManager = Products();

            ProductDetails();

        }

        private static void ProductDetails()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            var result = productManager.GetAllDetails();
            if (result.Success)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine("Product Name:" + item.ProductName + "Category Name:" + item.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
           
        }

        /*
        private static ProductManager Products()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var item in productManager.GetByUnitPrice(10, 20))
            {
                Console.WriteLine(item.ProductName);
            }

            return productManager;
        }
        */
    }
}
