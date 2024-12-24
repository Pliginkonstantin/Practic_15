using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        /// <summary>
        /// Задача 4. Генерируются 10 случайных целых чисел в интервале (-40, 40). Вывести эти числа.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Func();
            Console.Read();
        }
        static void Func()
        {
            Random Rand = new Random();
            for (int x = 1; x <= 10; x++)
            {
                int num = Rand.Next(-40, 40);
                Console.WriteLine($"{x} : {num}");
            }
        }
    }
}
