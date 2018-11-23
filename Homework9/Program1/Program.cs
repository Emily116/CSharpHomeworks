using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Collections;
using System.Text.RegularExpressions;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    public class Program
    {
        static void Main(string[] args)
        {
            String startUrl = "http://www.cnblogs.com/dstang2000/";
            Crawler crawler1 = new Crawler();
            crawler1.Start(startUrl, 20);
            ParallelCrawler crawler2 = new ParallelCrawler();
            //crawler2.Start(startUrl,20);
            Console.ReadKey();
        }
    }
}
