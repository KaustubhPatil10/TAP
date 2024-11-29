using System;
using System.Collections.Generic;
using System.Linq;
using BLL;
using Catalog;
namespace TesterApp
{
    public class LINQTest
    {
        // Will act like console UI
        static void Main(String[] args)
        {
            IEnumerable<Product> allProducts  = BusinessManager.GetAllProducts();


            foreach (Product theProduct in allProducts)
            {
                Console.WriteLine(theProduct.Title + " " + theProduct.Quantity);
            }


            List<int> numbers = new List<int>() { 5,4,1,3,9,8,6,7,2,0};

            // The query variable can also be implicitly typed by using var
            // Query #1.
            IEnumerable<int> filteringQuery = from num in numbers
                                              where num < 3 || num > 7
                                              select num;

            Console.WriteLine("Show number which are not in between 3 and 7");
            foreach(int score in filteringQuery)
            {
                Console.WriteLine(score);
            }

            // Query #2.
            IEnumerable<int> orderingQuery = from num in numbers
                                             where num < 3 || num > 7
                                             orderby num descending
                                             select num;

            Console.WriteLine("Show number which are not in between 3 and 7 in descending manner");
            foreach(int score in orderingQuery)
            {
                Console.WriteLine(score);
            }

            // instead of  var we can also write IEnumerable<Product> .

            /*var allSoldOutProducts = from product in allProducts
                                                      where product.Quantity == 0
                                                      select product; */

            IEnumerable <Product> allSoldOutProducts = BusinessManager.GetSoldOutProducts();
            Console.WriteLine(" Show only those product title which are sold out");
            
            foreach (Product theProduct in allSoldOutProducts)
            {
                Console.WriteLine(theProduct.Title + " " + theProduct.Quantity);
            } 

            Console.ReadLine();
        }
    }
}
