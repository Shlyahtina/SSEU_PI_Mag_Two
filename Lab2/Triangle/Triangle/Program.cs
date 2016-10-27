using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c; // длины сторон треугольника

            if (double.TryParse(Console.ReadLine(), out a) && double.TryParse(Console.ReadLine(), out b) && double.TryParse(Console.ReadLine(), out c))
            {
                // 1) существование треугольника
                /** a<b+c
                    a<c+a
                    c<a+b*/

                // 2) 

            }
            else { Console.WriteLine("Неверное значение! Введите число."); }
            Console.ReadKey();
        }
    }
}
