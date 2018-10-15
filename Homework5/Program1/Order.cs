using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class Order
    {
        private List<OrderDetails> orderdata = new List<OrderDetails>();

        public string Id { get; set; }
        public Client client { get; set; }
        public Order(string id, Client client)
        {
            this.Id = id;
            this.client = client;
        }

        //将一个订单的多种商品放入一个list中，可对每种商品进行操作
        public List<OrderDetails> Details
        {
            get => this.orderdata;
        }

        //修改订单
        //修改商品数量,返回修改好的订单
        public List<OrderDetails> ChangeAmount(OrderDetails product, int newamount)
        {
            product.OrderAmount = newamount;
            return orderdata;
        }

        //增加商品，返回修改好的订单
        public List<OrderDetails> AddProduct(OrderDetails orderDetail)
        {
            if (this.Details.Contains(orderDetail))
            {
                throw new Exception($"orderDetails-{orderDetail.goods.name} is already existed!");
            }
            Details.Add(orderDetail);
            return Details;
        }

        //减少商品，返回修改好的订单
        public List<OrderDetails> DeleteProduct(OrderDetails product)
        {
            int num = Details.IndexOf(product);
            if (num < 0) return null;
            else
            {
                Details.Remove(product);
            }
            return Details;
        }

        //实现IComparable接口
        //public void CompareTo()
    }
}
