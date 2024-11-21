using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{
    public class PurchaseOrderService : IOrderService
    {
        PurchaseManager mgr = PurchaseManager.GetManager();
        //private List<Order> orders = new List<Order>();
        public PurchaseOrderService()
        {
        }
        void IOrderService.Create(Order order)
        {
            GetOrders().Add(order);
            Console.WriteLine("created: {order.theCustomer.FullName}");
        }

        public bool Update(Order order)
        {
            bool status = false;
            return status;
            //return true;
        }

        public bool Cancel(Order order)
        {
            bool status = false;
            return status;
            //return true;
        }

        public bool Process(Order theOrder)
        {
            bool status = false;
            return status;
            //return true;
        }

        public List<Order> GetOrders()
        {
            List<Order> orders = new List<Order>();
            //Get all workOrders orders
            orders = mgr.Orders;
            return orders;
        }

        public Order GetOrder(int orderId)
        {
            Order theOrder = new Order();
            // get the work order based on id sent
            return theOrder;
        }

        
    }
}
 