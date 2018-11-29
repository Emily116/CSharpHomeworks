using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Xml.Serialization;
using System.Data.Entity;

namespace Program1
{
    public class OrderService
    {
        public OrderService() { }

        //在一个系统中存储多个订单
        public List<Order> orderlist = new List<Order>();

        //添加订单,返回新生成的订单系统
        public List<Order> AddOrder(Order order)
        {
            //Order neworder = new Order(ordernumber, client);
            using(var db = new OrderDB())
            {
                db.Order.Add(order);
                db.SaveChanges();
            }
            orderlist.Add(order);
            Console.WriteLine("Add an order " + order.OrderId + " from " + order.CliName);
            return orderlist;
        }

        //删除订单,返回新生成的订单系统
        public List<Order> DeleteOrder(Order order)
        {
            using(var db = new OrderDB())
            {
                db.Order.Remove(order);
                db.SaveChanges();
            }
            int num = orderlist.IndexOf(order);
            if (num < 0) return null;
            else
            {
                Console.WriteLine("Delete an order " + order.OrderId + " from " + order.OrderId);
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
                if (order.OrderId == number)
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
                if (order.CliName == name)
                {
                    orderFound = order;
                }
                else return null;
            }
            return orderFound;
        }

        //序列化成Xml
        public void Export(XmlSerializer ser, string FileName, object obj)
        {
            FileStream fs = new FileStream(FileName, FileMode.Create);
            ser.Serialize(fs, obj);
            fs.Close();
        }

        //Xml反序列化
        public object Import(string path)
        {
            if (Path.GetExtension(path) != ".xml")
                throw new ArgumentException("It isn't a xml file!");
            XmlSerializer xs = new XmlSerializer(typeof(List<Order>));

            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                List<Order> temp = (List<Order>)xs.Deserialize(fs);
                foreach(Order order in temp)
                {
                    orderlist.Add(order);
                }
            }
            return result;
        }
    }
}
