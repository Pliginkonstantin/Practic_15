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
        /// Задача 5. Генерируются 15 случайных целых чисел в интервале (-20, 30). Вывести эти числа и подсчитать количество положительных чисел.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Func();
            Console.Read();
        }
        static void Func()
        {
            int count = 0;
            Random Rand = new Random();
            for (int x = 1; x <= 15; x++)
            {
                int num = Rand.Next(-20, 30);
                Console.WriteLine($"{x} : {num}");
                if(num >= 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"количество положительных : {count}");
        }
    }
}
