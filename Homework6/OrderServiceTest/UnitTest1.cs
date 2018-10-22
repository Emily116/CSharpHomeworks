using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Program1;

namespace OrderServiceTest
{
    [TestClass]
    public class UnitTest1
    {
        public List<Order> orderlist = new List<Order>();

        //测试增加订单方法
        [TestMethod]
        public void AddOrder()
        {
            Client cli1 = new Client("1", "Mark");
            Client cli2 = new Client("2", "Coco");
            Client cli3 = new Client("3", "Jackson");
            Order ord1 = new Order("0001", cli1);
            Order ord3 = new Order("0003", cli3);
            OrderService os = new OrderService();
            os.orderlist.Add(ord1);
            os.orderlist.Add(ord3);

            os.AddOrder("0002", cli2);
            Assert.IsTrue(os.orderlist.Count() == 3);
        }

        //测试删除订单方法
        [TestMethod]
        public void DeleteOrder()
        {
            Client cli1 = new Client("1", "Mark");
            Client cli2 = new Client("2", "Coco");
            Client cli3 = new Client("3", "Jackson");
            Order ord1 = new Order("0001", cli1);
            Order ord3 = new Order("0003", cli3);
            OrderService os = new OrderService();
            os.orderlist.Add(ord1);
            os.orderlist.Add(ord3);

            os.DeleteOrder(ord1);
            Assert.IsTrue(os.orderlist.Count() == 1);
        }

        //测试查询订单方法

        Order orderFound;   //待找到的订单
        //根据订单编号查询订单,返回找到的订单
        [TestMethod]
        public void FindOrderByNumber()
        {
            Client cli1 = new Client("1", "Mark");
            Client cli2 = new Client("2", "Coco");
            Client cli3 = new Client("3", "Jackson");
            Order ord1 = new Order("0001", cli1);
            Order ord3 = new Order("0003", cli3);
            OrderService os = new OrderService();
            os.orderlist.Add(ord1);
            os.orderlist.Add(ord3);

            //os.FindOrderByNumber("0003")
            foreach (Order order in os.orderlist)
            {
                if (order.Id == "0003")
                {
                    orderFound = order;
                }
            }
            Assert.AreEqual(orderFound, ord3);
        }

        //根据商品名称查询订单,返回所有含该商品的订单
        List<Order> result = new List<Order>();
        [TestMethod]
        public void FindOrderByProName()
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

            //os.FindOrderByProName("Apple");
            foreach (Order order in os.orderlist)
            {
                for (int index = 0; index < os.orderlist.Count(); index++)
                    foreach (OrderDetails details in os.orderlist[index].Details)
                    {
                        if (details.goods.name == "Apple")
                        {
                            result.Add(order);
                        }
                    }
            }
            Assert.IsTrue(result.Count() == 2);//失败
        }

        //根据客户名称查询订单,返回所有含该商品的订单
        [TestMethod]
        public void FindOrderByCliName()
        {
            Order orderFound = null; //待找到的订单
            Client cli1 = new Client("1", "Mark");
            Client cli2 = new Client("2", "Coco");
            Client cli3 = new Client("3", "Jackson");
            Order ord1 = new Order("0001", cli1);
            Order ord3 = new Order("0003", cli3);
            OrderService os = new OrderService();
            os.orderlist.Add(ord1);
            os.orderlist.Add(ord3);

            //orderFound = os.FindOrderByCliName("Mark");
            foreach (Order order in os.orderlist)
            {
                if (order.client.name == "Mark")
                {
                    orderFound = order;
                }
            }
            Assert.AreEqual(orderFound, ord3);//失败
        }
    }
}
