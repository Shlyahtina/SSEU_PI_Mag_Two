using System;
using System.Collections.Generic;
using System.Text;

namespace Example4_SortAZ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слова:");
            string words = Console.ReadLine();

            string[] wordsArr = words.Split(' ');//разделить пробел
            Array.Sort(wordsArr);           
            words = wordsArr[0];
            for (int i = 1; i < wordsArr.Length; i++)
                words += " " + wordsArr[i];
          
            Console.WriteLine("Сортировка слов по алфавиту:");
            Console.WriteLine(words);
            Console.ReadKey();
        }
    }
}
