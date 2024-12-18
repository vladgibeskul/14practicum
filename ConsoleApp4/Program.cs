using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{/// <summary>
///  С использованием цветового оформления консоли:
/// а) вывести на экран горизонтальную строку из 18 символов;
/// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false; // инициализация для невидимого курсора 
            bool saveCursorVisibile = Console.CursorVisible;
            Console.Beep(659, 300);
            Console.Beep(659, 300);
            Console.Beep(659, 300);
            Console.BackgroundColor = ConsoleColor.White;//свойство установки белого цвета фона для текста 
            Console.ForegroundColor = ConsoleColor.Red;// свойство установки красного цвета шрифта
            Console.Title = "Работа с консолью";
            Func();
            Func1();
            Console.Read();
        }
        static void Func()
        { 
        for (int x=1;x<=18;x++)
            {
                Console.Write("#");
            }
        
           
        }
        static void Func1()
        {
            for (int x = 1; x <= 25; x++)
            {
                Console.WriteLine("#");
            }
        
        }
    }
}
