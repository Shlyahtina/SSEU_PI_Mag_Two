using System;
using System.Collections.Generic;
using System.Text;

namespace Temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            double temperatureC;
            double temperatureF;
            Console.WriteLine("on C to F");
            Console.WriteLine("Temperature on C");
            temperatureC = double.Parse(Console.ReadLine());
            temperatureF = (temperatureC*1.8)+32;
            Console.WriteLine("Temperature F:" + temperatureF);
            Console.ReadKey();  

        }
    }
}
