using System;
using System.Collections.Generic;
using System.Text;

namespace Faktorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int factorial=1;
            Console.WriteLine("������� �����:");
            if (int.TryParse(Console.ReadLine(), out number))
            {
                for (int i = 2; i <= number; i++)
                {
                    factorial *= i;
                   
                }
                Console.WriteLine("���������:" + factorial);
            }else {Console.WriteLine("�������� ��������! ������� �����."); }
            Console.ReadKey();
        }
    }
}
