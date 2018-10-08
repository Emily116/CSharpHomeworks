using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    //在整个订单系统中有多条订单
    class OrderService
    {
        //在一个系统中存储多个订单
        public List<Order> orderlist = new List<Order>();

        //添加订单,返回新生成的订单系统
        public List<Order> AddOrder(string ordernumber,string clientname)
        {
            Order neworder = new Order(ordernumber, clientname);
            orderlist.Add(neworder);
            Console.WriteLine("Add an order " + ordernumber + " from " + clientname);
            return orderlist;
        }

        //删除订单,返回新生成的订单系统
        public List<Order> DeleteOrder(Order order)
        {
            int num = orderlist.IndexOf(order);
            if (num < 0) return null;
            else
            {
                Console.WriteLine("Delete an order " + order.OrderNumber + " from " + order.ClientName);
                orderlist.Remove(order);
            }
            return orderlist;
        }

        //修改订单，即修改订单中商品的数量、增加商品减少商品等，在Order类中实现

        //查询订单（此处根据订单编号）,返回找到的订单
        Order orderFound; //待找到的订单
        public Order FindOrderByNumber(string number)
        {
            foreach(Order order in orderlist)
            {
                if (order.OrderNumber == number)
                {
                    orderFound = order;
                    return orderFound;
                }
                else return null;
            }
            return orderFound;
        }
    }
}
