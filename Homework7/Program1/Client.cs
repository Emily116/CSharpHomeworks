using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    public class Client
    {
        public string id { get; set; }

        public string name { get; set; }

        public OrderDetails od { get; set; }

        public Client(string id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public Client() { }
    }
}
