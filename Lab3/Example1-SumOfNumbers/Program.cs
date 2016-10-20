using System;
using System.Collections.Generic;
using System.Text;

namespace Example1_SumOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int countNumber;
            int number;
            Console.WriteLine("Enter the amount of numbers:");
            if (int.TryParse(Console.ReadLine(), out countNumber))
            {
                int sum = 0;
                for (int i = 0; i < countNumber; i++)
                {
                    Console.WriteLine("Enter the numbers " + (i + 1));
                    if (int.TryParse(Console.ReadLine(), out number))
                    {
                        sum += number;
                        /* DEBUG INFO
                        Console.WriteLine("sum"+sum);
                        // */ 
                    }
                    else
                    {
                        Console.WriteLine("Incorrect value! enter the number.");
                        i--;
                    } 
                };
                Console.WriteLine("Summa numbers" + sum);
                Console.ReadKey();
            };
            
        }
    }
}
