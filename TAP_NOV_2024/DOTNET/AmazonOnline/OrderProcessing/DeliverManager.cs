using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{
    public class DeliverManager : Manager
    {
        List<Order> orders = new List<Order>();

        public List<Order> Orders
        { get { return orders; } }

        public void Insert(Order order)
        {
            orders.Add(order);
        }

        public void Update(Order order)
        {
            orders.Remove(order);
        }

        public void Delete(Order order)
        {
            orders.Remove(order);
        }

        public List<Order> GetAll()
        {
            return orders;
        }

        public Order GetOrderByID(int orderId)
        {
            return orders[orderId];
        }

        public List<Order> GetByVendor(string vendor)
        {
            List <Order> orders = new List<Order>();
            foreach (WorkOrder order in this.orders)
            {
                if (order.Vendor == vendor)
                    return orders;
            }
            return null;
        }

    }
}
