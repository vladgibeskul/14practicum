using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{/// <summary>
/// генерируется 12 случайных целых чисел в интервале (-50,50). Вывести эти числа и сообщения: отрицательное-положительное.
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
            Random random = new Random();
            for (int i = 0; i < 12; i++)
            {
                int number = random.Next(-50,50);
                if (number == 0) Console.WriteLine($"{number} - равно нулю");
                if (number > 0) Console.WriteLine($"{number} - положительное число");
                if (number < 0) Console.WriteLine($"{number} - отрицательное число");
            }
        }
    }
}
