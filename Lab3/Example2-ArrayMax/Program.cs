using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2_ArrayMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthArray;
            do
            {
                Console.Write("ВВедите длину массива:");
            } while (!int.TryParse(Console.ReadLine(), out lengthArray) || (lengthArray <= 0));
            int[] array = new int[lengthArray];
            int i = 0;
            while (i < lengthArray) 
            {
                Console.Write("Введите array[" + i + "]: ");
                if (int.TryParse(Console.ReadLine(), out array[i]))
                {
                    i++; 
                }
                else 
                { 
                    Console.WriteLine("Введите целое число");
                }; ;
            };
            int max = array[0];
            int iMax = 0;
            for (int k = 1; k < array.Length; k++) 
            {
                if (array[k] > max) 
                { 
                    max = array[k];
                    iMax = k;
                };
            };
            Console.WriteLine("Максимально число array["+iMax+"]= " +max); 
            Console.ReadKey();
        }
    }
}
