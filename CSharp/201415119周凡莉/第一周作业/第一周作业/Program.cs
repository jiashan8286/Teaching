﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第一周作业
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("好好学习，天天向上！");
            Console.ReadLine();
            int n;
            Console.WriteLine("Enter a number:");
            n = Convert.ToInt32(Console.ReadLine());
            if (Math.Pow(n, 2) % 3 == 0) Console.WriteLine("能被3整除!\n");
            else Console.WriteLine("输入不正确\n");
            int i1 = 50;
            int sum1 = 0;
            Console.WriteLine("初值是{0}", i1);
            //for
            for (i1 = 50; 50 <= i1; i1++)
            {
                if (i1 % 7 == 0)
                {
                    sum1 += i1;
                }
                if (i1 <= 100)
                    continue;
                else break;
            }
            Console.WriteLine("终值是{0}", i1 - 1);
            Console.WriteLine("sum1={0}", sum1);
            Console.ReadKey();
            //while
            int i2 = 50;
            int sum2 = 0;
            Console.WriteLine("初值是{0}", i2);
            do
            {
                if (i2 % 7 == 0)
                {
                    sum2 += i2;
                }
                i2++;
                if (i2 <= 100)
                    continue;
                else
                    break;
            } while (i2 <= 100);
            Console.WriteLine("终值是{0}", i2 - 1);
            Console.WriteLine("sum2={0}", sum2);
            Console.ReadKey();
            int m;
            Console.WriteLine("Enter a number:");
            m = Convert.ToInt32(Console.ReadLine());
            switch (m % 2)
            {
                case 1:
                    Console.WriteLine("奇数");
                    break;
                case 0:
                    Console.WriteLine("偶数");
                    break;
            }
        }
    }
}
