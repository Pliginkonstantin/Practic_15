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
            decimal price = 20.4m;
            int num = 20;
            Func(num, price);
            Console.Read();
        }
        static void Func(int num, decimal price)
        {
            
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine($"{i} : {price * i}");
            }

        }

    }
}
