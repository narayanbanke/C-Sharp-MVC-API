using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerofOtherclass
{
    class Program
    {
        public class Customer
        {
            public List<Order> Orders
            {
                get; set;
            }
            public Order this[int orderID]
            {
                get
                {
                    return (from o in Orders
                            where o.OrderID == orderID
                            select o).First();
                }
            }
        }
        public class Order
        {
            public int OrderID
            {
                get; set;
            }
        }
        static void Main(string[] args)
        {
            List<Order> lstOrder = new List<Order>();
            Order o1 = new Order();
            o1.OrderID = 1;
            Order o2 = new Order();
            o2.OrderID = 2;
            lstOrder.Add(o1);
            lstOrder.Add(o2);
            Customer customer = new Customer();
            customer.Orders = lstOrder;
            Order o = customer[1];
            Console.WriteLine(o.OrderID);
            Console.ReadLine();
        }
    }
}
