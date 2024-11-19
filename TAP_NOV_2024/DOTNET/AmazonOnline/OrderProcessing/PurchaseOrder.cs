using CRM;
using System;
using System.Collections.Generic;
using ShoppingCart;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{
    public class PurchaseOrder :Order
    {


        public Customer theCustomer { get; set; }
        public List<Item> Items = new List<Item>();

        public PurchaseOrder() { }

        public PurchaseOrder(int orderId, DateTime orderDate, Customer theCustomer, List<Item> items)
        {
            this.OrderID = orderId;
            this.OrderdDate = orderDate;
            this.theCustomer = theCustomer;
            this.Items = items;
        }
    }
}
