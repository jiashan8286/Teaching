﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实验一
{
    class Program
    {
        static void Main(string[] args)
        {//实验一：c#语法及流程控制基础
            //宋仕楠   201415111
            //一、简单入门      1.输出“hello word！”。 
            Console.WriteLine("hello world");
            Console.ReadKey();



            //二、if语句       1.输入一个10以内整数，判断是否是能被2整除。输入数字不符合提示“输入不正确”。
            int N, n;
            Console.WriteLine("请输入一个10以内的整数：");
            N = Convert.ToInt32(Console.ReadLine());
            n = N % 2;
            if (n > 0)
                Console.WriteLine("输入不正确");
            Console.ReadKey();



            //三、用while实现如下功能。（要求：打印的循环变量的初值必须为1，终值为100。提示：使用break）
            //1.求1:50偶数的累加和。并打印循环变量的初值和终值。
            int sum1 = 0;
            int i1 = 1;
            Console.WriteLine("循环变量初值为：{0}", i1);
            while (i1 <= 50)
            {
                if (i1 % 2 == 0)
                {
                    sum1 = sum1 + i1;
                }
                i1++;
            }
            Console.WriteLine("循环变量终值为：{0}", i1 - 1);
            Console.WriteLine("1:50偶数的累加和sum1={0}", sum1);
            Console.ReadKey();




            //四、用for实现如下功能。（要求：打印的循环变量的初值必须为1，终值为100。提示：使用continue）
            //1.求1:50偶数的累加和。并打印循环变量的初值和终值。
            int sum2 = 0;
            int i2 = 1;
            Console.WriteLine("循环变量初值为：{0}", i2);
            for (i2 = 1; i2 <= 50; i2++)
            {
                if (i2 % 2 == 0)
                    sum2 = sum2 + i2;
            }
            Console.WriteLine("循环变量终值为：{0}", i2 - 1);
            Console.WriteLine("1:50偶数的累加和sum2={0}", sum2);
            Console.ReadKey();




            //五、用switch（case）实现以下功能。
            //1.输入一个月份(1:12)返回对应季节。
            int month;
            Console.WriteLine("请输入月份：");
            month = Convert.ToInt32(Console.ReadLine());
            switch (month)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("{0}月是春季", month);
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("{0}月是夏季", month);
                    break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine("{0}月是秋季", month);
                    break;
                case 10:
                case 11:
                case 12:
                    Console.WriteLine("{0}月是冬季", month);
                    break;
            }
            Console.ReadKey();
        }
    }
}
