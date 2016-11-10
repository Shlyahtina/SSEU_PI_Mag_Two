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

            Console.Write("������� �����: ");
            while (!double.TryParse(Console.ReadLine(), out operand)) 
            {
                Console.Write("�������� ��������! ������� �����: ");
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
                Console.WriteLine("������� ��������: '+'  '-'  '*'  '/'  'sqrt'");
                operation = Console.ReadLine();                
                //operation = operation.ToLower();//����������� ��������� ������ � ������ �������
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
                    default: Console.WriteLine("�������� ��������"); break;
                };
                Console.WriteLine(" = " + operand1);
            }
            while (!((operation == "quit") || (operation == "exit")));
            Console.ReadKey();
        }
    }
}
