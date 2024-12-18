using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {/// <summary>
     /// Вывести на экран в столбик первые 10 натуральных чисел (циклы с условием, цикл с параметром)
     /// </summary>
     /// <param name="args"></param>
        static void Main(string[] args)
        {
            Func();
            Console.ReadKey();
        }
        public static void Func()
        {
            for (int x = 10; x >= 1; x--)
            {
                Console.WriteLine(x);
            }
        }
        //public static void Func()
        //{
        //    for (int x = 1; x <= 10; x++)
        //    { 
        //    Console.WriteLine(x);
        //    }
        //}
        //public static void Func()
        //{
        //    int x = 1;
        //    do
        //    {
        //        Console.WriteLine(x);
        //        x++;
        //    }
        //    while (x <= 10);
        //}
        //static void Func()
        //{
        //    int x = 1;
        //    while (x<=10)
        //    {
        //        Console.WriteLine(x);
        //        x++;
        //    }
        //}
    }
}
