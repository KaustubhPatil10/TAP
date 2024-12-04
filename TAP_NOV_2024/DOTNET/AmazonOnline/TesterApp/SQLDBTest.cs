using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catalog;
using BLL;
namespace TesterApp
{
    public class SQLDBTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Database Connectivity Program");

            bool status = false;

            Product newProduct = new Product();
            newProduct.ID = 7;
            newProduct.Title = "Gerbera flower";
            newProduct.Description = " Wedding Flower used for designing";
            newProduct.UnitPrice = 20;
            newProduct.Quantity = 2500;
            status = BusinessManager.InsertProduct(newProduct);

            //Product theProduct = BusinessManager.GetProduct(5);
            //theProduct.UnitPrice = 199;
            //theProduct.Quantity = 19999;
            //status = BusinessManager.UpdateProduct(theProduct);


            //status = BusinessManager.DeleteProduct(7);
            IEnumerable<Product> allProducts = BusinessManager.GetAllProducts();
            foreach (Product product in allProducts)
            {
                Console.WriteLine("Title = {0}, Quantity = {1}", product.Title, product.Quantity);
                Console.WriteLine("Description = {0}", product.Description);
            }
            Console.ReadLine();
        }
    }
}
