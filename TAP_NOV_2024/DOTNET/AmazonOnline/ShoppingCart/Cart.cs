using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class Cart
    {
        private List<Item> items = new List<Item>(); //generic list collection of items

        public List<Item> Items
        {
            get { return items; }
            set { items = value; }
        }

        public void AddToCart(Item item)
        {
            Items.Add(item);
        }

        public void RemoveFromCart(Item item)
        {
            Items.Remove(item);
        }
    }
}
