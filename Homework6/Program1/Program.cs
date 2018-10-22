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
    public class Program
    {
        static void Main(string[] args)
        {
            try
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

                os.orderlist[0].AddProduct(pro1);
                os.orderlist[0].AddProduct(pro2);
                os.orderlist[0].AddProduct(pro3);
                os.orderlist[1].AddProduct(pro1);
                os.orderlist[1].AddProduct(pro3);
                os.orderlist[2].AddProduct(pro3);

                //XML序列化
                XmlSerializer xmlser = new XmlSerializer(typeof(List<Order>));
                string xmlFileName = "s.xml";
                os.Export(xmlser, xmlFileName, os.orderlist);

                //显示xml文本
                string xml = File.ReadAllText(xmlFileName);
                Console.WriteLine(xml);

                //XML反序列化
                List<Order> orders = os.Import(xmlser, xmlFileName) as List<Order>;
                foreach (Order order in orders)
                {
                    Console.WriteLine(order);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
