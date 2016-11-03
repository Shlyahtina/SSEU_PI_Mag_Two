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

            Console.ReadKey();

            if (double.TryParse(Console.ReadLine(), out operand1) && double.TryParse(Console.ReadLine(), out operand2))
            {

            }
            else { Console.WriteLine("Операнд должен быть числом!"); };

            //выбираем операцию
            operation = Console.ReadLine();
            switch (operation) 
            {
                case "+": result = operand1 + operand2; break;
                case "-": result = operand1 - operand2; break;
                case "*": result = operand1 * operand2; break;
                case "/": result = operand1 / operand2; break;
                case "sqrt": break;
                default: Console.WriteLine("Неверная операция"); break;
            };
        }
    }
}
