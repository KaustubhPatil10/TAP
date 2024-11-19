using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{
    public interface IOrderService
    {
        void Create(Order order);
        bool Update(Order order);
        bool Cancel(Order order);
        bool Process(Order theOrder);
        List<Order> GetOrders();
        Order GetOrder(int orderId);

    }
}
