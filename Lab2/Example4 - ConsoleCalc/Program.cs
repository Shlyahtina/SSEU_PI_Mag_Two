using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example4___ConsoleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            double operand1 = 0;
            double operand2 = 0;
            double result = 0;
            string operation;

            Console.WriteLine("Введите первое число");
                       
            if (double.TryParse(Console.ReadLine(), out operand1))
            {
                Console.WriteLine("Введите операцию: '+'  '-'  '*'  '/'  'sqrt'");
                operation = Console.ReadLine();
                switch (operation) 
                {
                    case "+": 
                    case "-": 
                    case "*": 
                    case "/":

                    Console.WriteLine("Введите второе число");
                    if(double.TryParse(Console.ReadLine(), out operand2))
                    {
                         switch (operation) 
                         {
                            case "+": result = operand1 + operand2; break;
                            case "-": result = operand1 - operand2; break;
                            case "*": result = operand1 * operand2; break;
                            case "/": result = operand1 / operand2; break;
                        };
                    }
                    else
                    {
                        Console.WriteLine("Операнд должен быть числом!");
                    };
                    break;

                    case "sqrt": result = Math.Sqrt(operand1); break;
                    default: Console.WriteLine("Неверная операция"); break;
                };
                Console.WriteLine(operand1 + " " + operation+ " " + operand2 + " = " +result);
            }
            else 
            {
                Console.WriteLine("Операнд должен быть числом!");
            };
            Console.ReadKey();
        }
    }
}
