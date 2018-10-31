using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    public class Goods
    {
        public string id { get; set; }

        public string name { get; set; }

        public double price { get; set; }

        public Goods(string id, string name, double price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }
        public Goods() { }
    }
}
