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
            int max = int.MinValue;
            while (i < lengthArray) 
            {
                Console.Write("Введите array[" + i + "]: ");
                if (int.TryParse(Console.ReadLine(), out array[i]))
                {
                    if (array[i] > max) { max = array[i]; };
                    i++; 
                }
                else 
                { 
                    Console.WriteLine("Введите целое число");
                }; ;
            };
            
            Console.WriteLine("Максимально число "+max); 
            Console.ReadKey();
        }
    }
}
