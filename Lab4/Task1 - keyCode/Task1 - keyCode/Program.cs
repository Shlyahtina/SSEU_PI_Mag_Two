using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1___keyCode
{
    class Program
    {
        static void Main(string[] args)
        {

            char key;
            Console.WriteLine("Нажмите клавишу");
            key=Console.ReadKey().KeyChar;
            Console.WriteLine("\n");
            int code;
            code = Convert.ToInt32(key);
            Console.WriteLine(code);
            Console.ReadKey();
            
        }
    }
}
