using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    class OrderDetails
    {
        public string OrderName;       //商品名称
        public int OrderAmount;        //商品数量
        public double OrderPrice;      //商品单价
        public OrderDetails(string name, int amount, double price)
        {
            this.OrderName = name;
            this.OrderAmount = amount;
            this.OrderPrice = price;
        }
    }
}
