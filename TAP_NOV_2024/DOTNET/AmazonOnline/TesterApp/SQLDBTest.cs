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
            IEnumerable<Product> allProducts = BusinessManager.GetDataFromDatabase();
            foreach (Product product in allProducts)
            {
                Console.WriteLine("Title = {0}", product.Title);
            }
            
            Console.ReadLine();
        }
    }
}
