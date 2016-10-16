using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabaTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;            
            if (int.TryParse(Console.ReadLine(), out A) && int.TryParse(Console.ReadLine(), out B) && int.TryParse(Console.ReadLine(), out C))
            {
                int max = (A >= B) ? A : B;
                max = (max >= C) ? max : C;
                Console.WriteLine("Max = " + max);
            }
            else { Console.WriteLine("Неверное значение! Введите целое число."); };
            Console.ReadKey();
        }
    }
}
