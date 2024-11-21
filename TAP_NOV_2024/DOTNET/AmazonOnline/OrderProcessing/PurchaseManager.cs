using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{

    // Singleton pattern
    // allows only one instance of class will be created
    // 1.define private constructor
    // 2.Keep self reference as ststic variable to class.
    // 3.Create instance of class by verifying reference nullability
    //   with the help of static method
    public class PurchaseManager
    {
        List<Order> orders = new List<Order>();

        private static PurchaseManager _ref = null;

        private PurchaseManager()
        {

        }

        public static PurchaseManager GetManager()
        {
            if(_ref == null)
            {
                _ref = new PurchaseManager();
                return _ref;
            }
            else
            {
                return _ref;
            }
        }


        public List<Order> Orders { get; set; }
        public void Insert(Order order)
        {
            orders.Add(order);
        }
        public void Update(Order order)
        {
            orders.Remove(order);
            orders.Add(order);
        }
        public void Delete(Order order)
        {
            orders.Remove(order);
        }

        public List<Order> GetAll()
        {
            return orders.ToList();
        }

    }
}
