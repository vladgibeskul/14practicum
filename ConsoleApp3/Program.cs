using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{/// <summary>
/// Вывести в столбик 5 раз слово «Привет!» (циклы с условием)
/// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Func();
            Console.ReadKey();
        }
        public static void Func()
        {
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("Привет!!!");
            }
        }
    }
}
