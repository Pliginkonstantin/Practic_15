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
        /// Задача 2. Одна штука некоторого товара стоит 20,4 руб. Напечатать таблицу стоимости 2, 3, ..., 20 штук этого товара.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WindowHeight = 60;
            Func();
            Console.Read();
        }
        static void Func()
        {
            int count = 0;
            for(int i = 10; i <= 99; i++)
            {
                if (i % 2 == 0)
                {
                    count++;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine($"количество : {count}");

        }

    }
}
