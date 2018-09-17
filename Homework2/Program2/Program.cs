using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Program2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Please enter the array: ");
            string s = Console.ReadLine();
            string[] array = s.Split(' ');
            int nLen = array.Length;
            int[] numbers = new int[nLen];
            for(int i = 0;i < nLen; i++)
            {
                numbers[i] = Int32.Parse(array[i]);
            }
            int nMax = numbers[0], nMin = numbers[0];
            double nSum = 0, nAver = 0;
            for(int i = 1;i < nLen - 1; i++)
            {
                for(int j = nLen - 1;j > i; j--)
                {
                    if (numbers[j] < numbers[j - 1]) nMin = numbers[j];
                    else if (numbers[j] > numbers[j - 1]) nMax = numbers[j];
                }
            }
            for(int i = 0;i < nLen; i++)
            {
                nSum += numbers[i];
            }
            nAver = nSum / nLen;
            System.Console.WriteLine("The maximum = " + nMax);
            System.Console.WriteLine("The minimum = " + nMin);
            System.Console.WriteLine("The sum = " + nSum);
            System.Console.WriteLine("The average = " + nAver);
        }
    }
}
