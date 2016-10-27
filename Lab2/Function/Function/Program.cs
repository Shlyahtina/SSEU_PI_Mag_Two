using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function
{
    class Program
    {
        static void Main(string[] args)
        {

            double x, function, a, b, c;

            a = 20;
            b = 1;
            c = 1994;
            
            Console.WriteLine("Введите значение х");
            x = double.Parse(Console.ReadLine());
            function = (((-x) * (Math.Sqrt(x*x+b*x)))/ a) + c;
            Console.WriteLine("Function f(x):" + function);
            Console.ReadKey();
        }
    }
}
