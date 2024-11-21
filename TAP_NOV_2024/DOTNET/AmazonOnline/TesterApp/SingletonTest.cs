using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catalog;
using CRM;
using OrderProcessing;
using ShoppingCart;

namespace TesterApp
{
    class SingletonTest
    {
        static void Main(string [] args)
        {
            PurchaseManager mgr1, mgr2, mgr3;
            mgr1 = PurchaseManager.GetManager();
            mgr2 = PurchaseManager.GetManager();
            mgr3 = PurchaseManager.GetManager();

            mgr1.Orders = new List<Order>();

            Product product1 = new Product(1, "Rose", "Valentine flower", 1500, 200);
            Product product2 = new Product(1, "Marigold", "Festival flower", 3500, 120);

            Item item1 = new Item(product1, 34);
            Item item2 = new Item(product2, 56);

            Cart cart1 = new Cart();

            cart1.AddToCart(item1);
            cart1.AddToCart(item2);

            List<Item> cartItems = cart1.Items;
            DateTime ordDate = DateTime.Now;
            Customer customer1 = new Customer
            {
                UserID = "100",
                FullName = "Kaustubh Patil",
                Email = "kaustubhpatil331@gmail.com",
                ContactNumber = "9876543210",
                Location = "Mumbai",
                Password = "seed"
            };
            Order theOrder = new PurchaseOrder(1001, ordDate, customer1, cartItems);

            mgr1.Orders = new List<Order>();
            mgr1.Orders.Add(theOrder);

            Console.ReadLine();
        }
    }
}
