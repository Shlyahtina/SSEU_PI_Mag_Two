using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int summ = 0;
            int rem  =0;
            Console.WriteLine("Введите число:");
            if (int.TryParse(Console.ReadLine(), out number))
            {
                int i = 0;
               while (number>0) 
                {                 
                    number = Math.DivRem(number, 10, out rem);        
                    summ += rem;
                    i++;
                }
                Console.WriteLine("Сумма чисел:" + summ);
                Console.WriteLine("Количество чисел:" + i);
            }
            else { Console.WriteLine("Не корректное значени! введите число."); }
            Console.ReadKey();
        }
    }
}
