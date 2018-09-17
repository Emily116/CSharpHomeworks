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
            string s = " ";
            int p = 0;
            System.Console.Write("Please input a number: ");
            s = System.Console.ReadLine();
            int n = Int32.Parse(s);
            if (n <= 1) System.Console.WriteLine("无素数因子");
            else
            {
                System.Console.Write("素数因子有: ");
                for (int i = 2; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        for (int j = 2; j < i; j++)
                        {
                            if (i % j == 0) p++;
                        }
                        if (p == 0) System.Console.Write(i + " ");
                    }
                }
            }
        }
    }
}
