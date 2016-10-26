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
            int factorial=1;
            Console.WriteLine("Введите число:");
            if (int.TryParse(Console.ReadLine(), out number))
            {
                for (int i = 2; i <= number; i++)
                {
                    factorial *= i;
                   
                }
                Console.WriteLine("Факториал:" + factorial);
            }else {Console.WriteLine("Неверное значение! Введите число."); }
            Console.ReadKey();
        }
    }
}
