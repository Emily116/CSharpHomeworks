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
            Client cli1 = new Client("1", "Mark");
            Client cli2 = new Client("2", "Coco");
            Client cli3 = new Client("3", "Jackson");

            Goods apple = new Goods("1", "Apple", 1.5);
            Goods milk = new Goods("2", "Milk", 3.0);
            Goods bed = new Goods("3", "Bed", 200);

            OrderDetails pro1 = new OrderDetails("1", 4, apple);
            OrderDetails pro2 = new OrderDetails("2", 2, milk);
            OrderDetails pro3 = new OrderDetails("3", 1, bed);
      
            Order ord1 = new Order("0001", cli1);
            Order ord2 = new Order("0002", cli2);
            Order ord3 = new Order("0003", cli3);

            ord1.AddProduct(pro1);
            ord1.AddProduct(pro2);
            ord1.AddProduct(pro3);
            ord2.AddProduct(pro1);
            ord2.AddProduct(pro3);
            ord3.AddProduct(pro3);
            OrderService os = new OrderService();
            os.orderlist.Add(ord1);
            os.orderlist.Add(ord2);
            List<Order> norder1 = os.AddOrder("0002", cli2);
            foreach(Order order in norder1)
            {
                Console.WriteLine("OrderNumber : " + order.Id + "ClientName : " + order.client.name);
            }
            List<Order> norder2 = os.DeleteOrder(ord2);
            foreach (Order order in norder2)
            {
                Console.WriteLine("OrderNumber : " + order.Id + "ClientName : " + order.client.name);
            }
            Order norder3 = os.FindOrderByNumber("0003");
            Console.WriteLine("OrderNumber : " + norder3.Id + "ClientName : " + norder3.client.name);
        }
    }
}
