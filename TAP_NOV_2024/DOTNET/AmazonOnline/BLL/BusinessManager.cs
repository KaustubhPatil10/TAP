using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catalog;
using DAL;

namespace BLL
{
    public static class BusinessManager
    {

        public static Product GetProduct(int id)
        {
            return CatalogDBManager.GetProductByID(id);
        }

     public static IEnumerable<Product> GetAllProducts()
     {
            //IEnumerable<Product> allProducts = CatalogDBManager.GetAllProducts();
            IEnumerable<Product> allProducts = CatalogDBManager.GetAllProductsUsingDisconnected();
            return allProducts;

            #region hardcoded way
            /* List<Product> allProducts = new List<Product>();
            allProducts.Add(new Product { ID = 1, Title = "Gerbera", Description = "Wedding FLowers", UnitPrice = 6,  Quantity = 5000 });
            allProducts.Add(new Product { ID = 2, Title = "Rose", Description = "Valentine FLowers", UnitPrice = 6, Quantity = 7000 });
            allProducts.Add(new Product { ID = 3, Title = "Lotus", Description = "Worship FLowers", UnitPrice = 6, Quantity = 0 });
            allProducts.Add(new Product { ID = 4, Title = "Carnation", Description = "Pink carnation signifies a Mother's Lover", UnitPrice = 6, Quantity = 27000 });
            allProducts.Add(new Product { ID = 5, Title = "Lily", Description = "Lilies are among the most popular flowers in the U.S", UnitPrice = 6, Quantity = 1000 });
            allProducts.Add(new Product { ID = 6, Title = "Jasmine", Description = "Jasmine is a genus pf shrubs and vines in the olive family", UnitPrice = 6, Quantity = 0 });
            allProducts.Add(new Product { ID = 7, Title = "Daisy", Description = "Give a gift of these cheerful flower as a symbol of your Loyalty and pure intentions", UnitPrice = 6, Quantity = 159 });
            allProducts.Add(new Product { ID = 8, Title = "Aster", Description = "Asters are the september birth flowers", UnitPrice = 6, Quantity = 67 });
            allProducts.Add(new Product { ID = 9, Title = "Daffodil", Description = "Wedding flower", UnitPrice = 6, Quantity = 5000 });
            allProducts.Add(new Product { ID = 10, Title = "Dahlia", Description = "Dahlias are a popular and glamorous summer flower", UnitPrice = 6, Quantity = 0 });
            allProducts.Add(new Product { ID = 11, Title = "Hydrangea", Description = "Hydrangea is the fourth wedding anniversary flower", UnitPrice = 6, Quantity = 0 });
            allProducts.Add(new Product { ID = 12, Title = "Orchid", Description = "Orchids are exotic and beautiful making a perfect bouquet", UnitPrice = 6, Quantity = 700 });
            allProducts.Add(new Product { ID = 13, Title = "Statice", Description = "Surprise them with this fresh, fabulous array of Static flowers", UnitPrice = 6, Quantity = 1500 });
            allProducts.Add(new Product { ID = 14, Title = "Sunflower", Description = "Sunflowers express your pure love", UnitPrice = 6, Quantity = 2500 });
            allProducts.Add(new Product { ID = 15, Title = "Tulip", Description = "Tulips are the quintessential spring flower and available from January", UnitPrice = 6, Quantity = 10000 }); */
            #endregion
     }

        public static IEnumerable<Product> GetSoldOutProducts()
        {
            IEnumerable<Product> products = GetAllProducts();
            return products;

            // apply filter
            // apply some business query
            // var is used to represent a Dynamic Variable.
            // where the type will be known at Run Time and not on Compile Time. 
            // var is known as a Data Type.
            // LINQ: Language Intergated Query
            // var soldOutProducts = from product in products select product;
            /*var soldOutProducts = from product in products
                                     where product.Quantity == 0
                                     select product;
            return soldOutProducts; */

        }

        public static bool InsertProduct(Product theProduct)
        {
            return CatalogDBManager.Insert(theProduct);
        }

        public static bool UpdateProduct(Product theProduct)
        {
            return CatalogDBManager.Update(theProduct);
        }


        public static bool DeleteProduct(int id)
        {
            return CatalogDBManager.Delete(id);
        }
    }
}
