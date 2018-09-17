using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program3
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Please enter a number:");
            string s = Console.ReadLine();
            int n = Int32.Parse(s);
            System.Console.Write(n + "以内的素数有");
            int[] array = new int[n];
            int nLen = 0;
            for(int i = 0;i < n - 1; i++)
            {
                array[i] = i + 2;
            }//将2到n的整数放入数组
            for(int j = 2;j <= n; j++)
            {
                for(int k = 0;k < n - 1; k++)
                {
                    if(array[k] % j == 0 && array[k] != j)
                    {
                        array[k] = 0;
                    }
                }
            }//使j(2到n)的倍数为0
            for(int k = 0;k < n - 1; k++)
            {
                if (array[k] != 0) nLen++;
            }//计算素数个数
            int[] newArray = new int[nLen];//新数组存放素数
            for(int i = 0, j = 0;i < nLen; i++, j++)
            {
                if (array[j] != 0) newArray[i] = array[j];
                else
                {
                    while (array[j] == 0) j++;
                    newArray[i] = array[j]; 
                }
                System.Console.Write(newArray[i] + " ");
            }
        }
    }
}
