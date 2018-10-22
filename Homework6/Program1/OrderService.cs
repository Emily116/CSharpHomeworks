using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Xml.Serialization;

namespace Program1
{
    public class OrderService
    {
        public OrderService() { }

        //在一个系统中存储多个订单
        public List<Order> orderlist = new List<Order>();

        //添加订单,返回新生成的订单系统
        public List<Order> AddOrder(string ordernumber, Client client)
        {
            Order neworder = new Order(ordernumber, client);
            orderlist.Add(neworder);
            Console.WriteLine("Add an order " + ordernumber + " from " + client);
            return orderlist;
        }

        //删除订单,返回新生成的订单系统
        public List<Order> DeleteOrder(Order order)
        {
            int num = orderlist.IndexOf(order);
            if (num < 0) return null;
            else
            {
                Console.WriteLine("Delete an order " + order.Id + " from " + order.Id);
                orderlist.Remove(order);
            }
            return orderlist;
        }

        //修改订单，即修改订单中商品的数量、增加商品减少商品等，在Order类中实现


        Order orderFound; //待找到的订单
        //根据订单编号查询订单,返回找到的订单
        public Order FindOrderByNumber(string number)
        {
            foreach (Order order in orderlist)
            {
                if (order.Id == number)
                {
                    orderFound = order;
                    return orderFound;
                }
                else return null;
            }
            return orderFound;
        }

        public List<Order> result = new List<Order>();
        //根据商品名称查询订单,返回所有含该商品的订单
        public List<Order> FindOrderByProName(string name)
        {
            //List<Order> result = new List<Order>();
            foreach (Order order in orderlist)
            {
                for (int index = 0; index < orderlist.Count(); index++)
                    foreach (OrderDetails details in orderlist[index].Details)
                    {
                        if (details.goods.name == name)
                        {
                            result.Add(order);
                        }
                        else return null;
                    }
            }
            return result;
        }

        //根据客户名称查询订单,返回所有含该商品的订单
        public Order FindOrderByCliName(string name)
        {
            //List<Order> result = new List<Order>();
            foreach (Order order in orderlist)
            {
                if (order.client.name == name)
                {
                    orderFound = order;
                }
                else return null;
            }
            return orderFound;
        }

        //序列化成Xml
        public void Export(XmlSerializer ser, string FileName,object obj)
        {
            FileStream fs = new FileStream(FileName, FileMode.Create);
            ser.Serialize(fs, obj);
            fs.Close();
        }

        //Xml反序列化
        public object Import(XmlSerializer ser, string FileName)
        {
            FileStream fs = new FileStream(FileName, FileMode.Open);
            object obj = ser.Deserialize(fs);
            fs.Close();
            return obj;
        }
    }
}
