using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    //一个订单里有多种商品，并包含订单编号及客户姓名
    class Order
    {
        public string OrderNumber;
        public string ClientName;  
        public Order(string number,string name)
        {
            this.OrderNumber = number;
            this.ClientName = name;
        }

        //将一个订单的多种商品放入一个list中，可对每种商品进行操作
        public List<OrderDetails> orderdata = new List<OrderDetails>();

        //修改订单
        //修改商品数量,返回修改好的订单
        public List<OrderDetails> ChangeAmount(OrderDetails product,int newamount)
        {
            product.OrderAmount = newamount;
            return orderdata;
        }

        //增加商品，返回修改好的订单
        public List<OrderDetails> AddProduct(string name,int amount,double price)
        {
            OrderDetails newproduct = new OrderDetails(name, amount, price);
            orderdata.Add(newproduct);
            return orderdata;
        }

        //减少商品，返回修改好的订单
        public List<OrderDetails> DeleteProduct(OrderDetails product)
        {
            int num = orderdata.IndexOf(product);
            if (num < 0) return null;
            else
            {
                orderdata.Remove(product);
            }
            return orderdata;
        }
    }
}
