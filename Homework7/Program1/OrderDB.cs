using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Program2;

namespace Program1
{
    public class OrderDB : DbContext
    {
        public OrderDB() : base("orderingsystem")
        {
        }
        public DbSet<Order> Order { get; set; }

    }
}
