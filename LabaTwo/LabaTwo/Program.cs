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
            int A, B;
            if (int.TryParse(Console.ReadLine(), out A))
            {
                if (int.TryParse(Console.ReadLine(), out B))
                {
                    int max = (A >= B) ? A : B;

                    Console.WriteLine("Max = " + max);
                }
                else { Console.WriteLine("Невверное значение!Введите целое число."); };
            }
            else { Console.WriteLine("Невверное значение!Введите целое число."); };
            Console.ReadKey();
        }
    }
}
