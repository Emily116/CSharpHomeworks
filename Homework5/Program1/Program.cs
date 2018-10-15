using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class OrderingSystem
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
           
            OrderService os = new OrderService();
            os.orderlist.Add(ord1);
            os.orderlist.Add(ord2);
            os.orderlist.Add(ord3);

            //os.orderlist[0] = new Order("0001", cli1);
            //os.orderlist[1] = new Order("0002", cli2);
            //os.orderlist[2] = new Order("0003", cli3);

            os.orderlist[0].AddProduct(pro1);
            os.orderlist[0].AddProduct(pro2);
            os.orderlist[0].AddProduct(pro3);
            os.orderlist[1].AddProduct(pro1);
            os.orderlist[1].AddProduct(pro3);
            os.orderlist[2].AddProduct(pro3);


            //使用Linq语言查询订单
            //按照订单编号降序排列订单
            //Console.WriteLine("Here are descending orders :");
            //var m1 = from order in os.orderlist where order != null orderby order descending select order;
            //foreach(var order in m1) { Console.WriteLine(order); }

            //按照订单编号选出某编号的订单
            Console.WriteLine("Here are orders which is '0003' :");
            var m2 = from order in os.orderlist where order.Id == "0003" select order;
            foreach(var order in m2)
            { Console.WriteLine(order.client.id + " " + order.client.name); }

            //按照商品名称选出第一个订单中含某商品的订单
            Console.WriteLine("Here are orders containing apple :");
            var m3 = from order in os.orderlist[0].Details where order.goods.name == "Apple" select order;
            foreach(var order in m3)
            { Console.WriteLine(order.OrderId + " " + order.OrderAmount); }

            //按照客户名称选出该客户的订单
            Console.WriteLine("Here are orders from Mark :");
            var m4 = from order in os.orderlist where order.client.name == "Mark" select order;
            foreach(var order in m4)
            {
                for(int i=0;i<order.Details.Count();i++)
                {
                    Console.WriteLine(order.Details[i].OrderId + " " + order.Details[i].goods.name + " " 
                        + order.Details[i].OrderAmount + " " + order.Details[i].goods.price);
                }
            }

        }
    }
}
