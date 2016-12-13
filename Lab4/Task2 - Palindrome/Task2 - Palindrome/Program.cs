using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2___Palindrome
{
    class Program
    {

            static void Main(string[] args)
    {
        Console.WriteLine("Введите строку: ");
        string str = Console.ReadLine();
        bool b = true;
        str = str.Replace(" ",string.Empty).ToLower();

        for(int i = 0; i < str.Length / 2; i++)
        {
            if (str[i] != str[str.Length - i - 1])
                b = false;
        }
 
        Console.WriteLine(((b) ? "является" : "не является") + " палиндромом");
        Console.ReadKey();
        }
    }
}
