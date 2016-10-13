using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Helloy, word");
            string name;
            if (args.Length > 0) { 
                name =args[0];
            }else{
                Console.WriteLine("What's your name?");
                name = Console.ReadLine();
            };
            Console.WriteLine("Name:" + name);
            Console.ReadKey();
        }
    }
}
