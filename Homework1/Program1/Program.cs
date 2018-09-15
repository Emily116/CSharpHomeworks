using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1, s2 = " ";
            double n = 0;
            double d = 0;
            Console.Write("Please enter the first double:");
            s1 = Console.ReadLine();
            n = Double.Parse(s1);
            Console.Write("Please enter the second double:");
            s2 = Console.ReadLine();
            d = Double.Parse(s2);
            Console.WriteLine("You have entered:" + (n * d));
        }
    }
}
