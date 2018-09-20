using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());

            //Console.WriteLine("最大的数是：{0}", a > b ? a > c ? a : c : b > c ? b : c);
            //#region  random number
            //const int  m = 50;

            //long[] a = new long[m];
            //var r = new Random();
            //for (int i = 0; i < m; i++)
            //{
            //    a[i] = r.Next(0,10);

            //}

            //foreach (long x in a )
            //{
            //    Console.WriteLine(x);
            //}

            //Console.ReadLine();

            //#endregion

            Console.WriteLine("正在统计中。。。。");
            Console.WriteLine(FileOrDirCount("C:/lol"));
            Console.WriteLine("计算结束！");
            Console.ReadLine();

        }

        private static long FileOrDirCount(string path)
        {
            long count1 = 0;
            long count2 = 0;
            List<long> list = new List<long>();
            try
            {
                //统计file的个数
                var files = Directory.GetFiles(path);
                count1 += files.Length;
                //统计dir的个数
                var dirs = Directory.GetDirectories(path);
                count2 += dirs.Length;
                foreach (var dir in dirs)
                {
                    count2 += FileOrDirCount(dir);                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            list.Add(count1);
            list.Add(count2);
            return list;
            //Console.WriteLine("{0}and {1}", count1,count2);
        }
    }
   
}
