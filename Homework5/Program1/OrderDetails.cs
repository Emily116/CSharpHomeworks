using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class OrderDetails
    {
        public string OrderId { get; set; }       //商品编号

        public int OrderAmount { get; set; }        //商品数量

        public Goods goods { get; set; }     //商品

        public OrderDetails(string name, int amount, Goods goods)
        {
            this.OrderId = name;
            this.OrderAmount = amount;
            this.goods = goods;
        }
        public override bool Equals(object obj)
        {
            var detail = obj as OrderDetails;
            return detail != null &&
                goods.name == detail.goods.name &&
                OrderAmount == detail.OrderAmount;
        }
    }
}
