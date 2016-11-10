using System;
using System.Collections.Generic;
using System.Text;

namespace Example4_ConsoleCalc2
{
    class Program
    {
        static double ReadOperand() 
        { 
            double operand = 0;

            Console.Write("Введите число: ");
            while (!double.TryParse(Console.ReadLine(), out operand)) 
            {
                Console.Write("Неверное значение! Введите число: ");
            }; 
            return operand;
        }

        static void Main(string[] args)
        {
            double operand1 = ReadOperand();
            double operand2;
            double result = 0;
            string operation;

            do
            {
                Console.WriteLine("Введите операцию: '+'  '-'  '*'  '/'  'sqrt'");
                operation = Console.ReadLine();                
                //operation = operation.ToLower();//преобразует введенные данные в нижний регистр
                switch (operation)
                {
                    case "+":
                    case "-":
                    case "*":
                    case "/":
                    operand2 = ReadOperand();
                    switch (operation)
                    {
                        case "+": operand1 = operand1 + operand2; break;
                        case "-": operand1 = operand1 - operand2; break;
                        case "*": operand1 = operand1 * operand2; break;
                        case "/": operand1 = operand1 / operand2; break;
                    };
                    break;
                    case "sqrt": result = Math.Sqrt(operand1); break;
                    case "quit":
                    case "exit": return;
                    default: Console.WriteLine("Неверная операция"); break;
                };
                Console.WriteLine(" = " + operand1);
            }
            while (!((operation == "quit") || (operation == "exit")));
            Console.ReadKey();
        }
    }
}
