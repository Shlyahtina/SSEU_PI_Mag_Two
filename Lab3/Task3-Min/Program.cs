using System;
using System.Collections.Generic;
using System.Text;

namespace Task3_Min
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthArray;
            do
            {
                Console.Write("������� ����� �������:");
            } while (!int.TryParse(Console.ReadLine(), out lengthArray) || (lengthArray <= 0));
            int[] array = new int[lengthArray];
            int i = 0;
            while (i < lengthArray)
            {
                Console.Write("������� array[" + i + "]: ");
                if (int.TryParse(Console.ReadLine(), out array[i]))
                {
                    i++;
                }
                else
                {
                    Console.WriteLine("������� ����� �����");
                }; ;
            };           
            int min = array[0];
            string iMin = "0";
            for (int k = 1; k < array.Length; k++)
            {
                if (array[k] == min)
                {
                    iMin = iMin + "," + k;
                }
                else if (array[k] < min)
                {
                    min = array[k];
                    iMin = k.ToString();
                };
            };
            Console.WriteLine("����������� �����[" + iMin + "]= " + min);
            Console.ReadKey();
        }
    }
}
