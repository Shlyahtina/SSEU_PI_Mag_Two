using System;
using System.Collections.Generic;
using System.Text;

namespace Example3_SortArray
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
                }; 
            };

            for (i = 0; i < array.Length-1; i++) 
            {
                for (int j = 1; j < array.Length - i; j++) 
                {
                    if(array[j-1] > array[j])
                    {
                        int buffer = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = buffer;
                    }
                };
            };
            Console.WriteLine("��������������� ������");
            for (i = 0; i < array.Length; i++) 
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
