using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{/// <summary>
///  Вывести на экран целые числа из интервала от 1 до n (цикл с параметром)
/// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Input("n=");
            //Console.WriteLine("Введите число n");
            Func(n);
            Console.ReadKey();

        }
        public static int Input(string mes)
        {
            Console.Write(mes);
            return int.Parse(Console.ReadLine());
        }
        public static void Func(int n)
        {
            for (int i = 1; i <=n; i++)
            { 
                Console.WriteLine(i);
            }
        }
    }
}
