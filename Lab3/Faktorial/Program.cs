using System;
using System.Collections.Generic;
using System.Text;

namespace Faktorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int factorial;
            Console.WriteLine("Введите число:");
            if (int.TryParse(Console.ReadLine(), out number))
            {
              factorial = number * (number - 1);
              Console.WriteLine("Факториал:" + factorial);
            }else {Console.WriteLine("Неверное значение! Введите число."); }
            Console.ReadKey();
        }
    }
}
