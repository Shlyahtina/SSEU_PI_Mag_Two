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
            Console.WriteLine("Please enter the numbers:");
            if (int.TryParse(Console.ReadLine(), out number))
            {
               
                //Console.WriteLine("Ôàêòîðèàë:" + factorial);
            }
            else { Console.WriteLine("Incorrect value! enter the number."); }
            Console.ReadKey();
        }
    }
}
