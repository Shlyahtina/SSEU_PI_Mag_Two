using System;
using System.Collections.Generic;
using System.Text;

namespace Example3__Months
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberMonth;
            Console.Write("������� ����� ������");
            if (int.TryParse(Console.ReadLine(), out numberMonth))
            {
                switch (numberMonth)
                {
                    case 1: Console.Write("������"); break;
                    case 2: Console.Write("�������"); break;
                    case 3: Console.Write("����"); break;
                    case 4: Console.Write("������"); break;
                    case 5: Console.Write("���"); break;
                    case 6: Console.Write("����"); break;
                    case 7: Console.Write("����"); break;
                    case 8: Console.Write("������"); break;
                    case 9: Console.Write("��������"); break;
                    case 10: Console.Write("�������"); break;
                    case 11: Console.Write("������"); break;
                    case 12: Console.Write("�������"); break;
                    default: Console.Write("��� ������ ������"); break;
                };
            }
            else 
            {
                Console.Write("������� ����� ������");
            };
            Console.ReadKey();
        }
    }
}
