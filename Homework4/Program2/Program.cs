using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderDetails pro1 = new OrderDetails("apple", 4, 1.5);
            OrderDetails pro2 = new OrderDetails("milk", 2, 3.0);
            OrderDetails pro3 = new OrderDetails("bed", 1, 200);
            List<OrderDetails> productList1 = new List<OrderDetails>();
            List<OrderDetails> productList2 = new List<OrderDetails>();
            productList1.Add(pro1);
            productList1.Add(pro2);
            productList2.Add(pro3);
            Order ord1 = new Order("0001", "Mark");
            Order ord2 = new Order("0003", "Jackson");
            OrderService os = new OrderService();
            os.orderlist.Add(ord1);
            os.orderlist.Add(ord2);
            List<Order> norder1 = os.AddOrder("0002", "Coco");
            foreach(Order order in norder1)
            {
                Console.WriteLine("OrderNumber : " + order.OrderNumber + "ClientName : " + order.ClientName);
            }
            List<Order> norder2 = os.DeleteOrder(ord2);
            foreach (Order order in norder2)
            {
                Console.WriteLine("OrderNumber : " + order.OrderNumber + "ClientName : " + order.ClientName);
            }
            Order norder3 = os.FindOrderByNumber("0003");
            Console.WriteLine("OrderNumber : " + norder3.OrderNumber + "ClientName : " + norder3.ClientName);
        }
    }
}
