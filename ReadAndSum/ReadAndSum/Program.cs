using System;
using System.Collections.Generic;
using System.Text;

namespace ReadAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne;
            int numberTwo;
            int summ;
           
                Console.WriteLine("Number one");
                numberOne = int.Parse(Console.ReadLine()); ;
                Console.WriteLine("Number two");
                numberTwo = int.Parse(Console.ReadLine());
                summ = numberOne + numberTwo;
                Console.WriteLine("Summ:" + summ);
                Console.ReadKey();          
        }
    }
}
