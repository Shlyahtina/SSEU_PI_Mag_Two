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
            char.TryParse(Console.ReadLine(), out key);
            int code;
            code = Convert.ToInt32(key);
            Console.WriteLine(code);
            Console.ReadKey();
            
        }
    }
}
