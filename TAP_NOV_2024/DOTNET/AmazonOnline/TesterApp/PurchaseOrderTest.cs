using System;
using CRM;
using System.Collections.Generic;
using Catalog;
using ShoppingCart;

namespace OrderProcessing
{
    class PurchaseOrderTest
    {

        public static void Main(string[] args)
        {
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

            Product product1 = new Product(1, "Rose", "Valentine flower", 1500, 200);
            Product product2 = new Product(1, "Marigold", "Festival flower", 3500, 120);

            Item item1 = new Item(product1, 34);
            Item item2 = new Item(product2, 56);

            Cart cart1 = new Cart();

            cart1.AddToCart(item1);
            cart1.AddToCart(item2);

            List<Item> cartItems = cart1.Items;
            Order theOrder = new PurchaseOrder(1001, ordDate, customer1, cartItems); //here cartItems is a list of Item object.

            IOrderService service = new PurchaseOrderService();
            service.Create(theOrder);

            List<Order> allOrders = service.GetOrders();
            foreach(PurchaseOrder order in allOrders)
            {
                Console.WriteLine(order.theCustomer.FullName);
                Console.WriteLine(order.OrderdDate);
            }


        }
    }
}
