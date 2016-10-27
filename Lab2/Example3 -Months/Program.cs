using System;
using System.Collections.Generic;
using System.Text;

namespace Example3__Months
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberMonth;
            Console.Write("¬ведите номер мес€ца");
            if (int.TryParse(Console.ReadLine(), out numberMonth))
            {
                switch (numberMonth)
                {
                    case 1: Console.Write("январь"); break;
                    case 2: Console.Write("‘евраль"); break;
                    case 3: Console.Write("ћарт"); break;
                    case 4: Console.Write("јпрель"); break;
                    case 5: Console.Write("ћай"); break;
                    case 6: Console.Write("»юнь"); break;
                    case 7: Console.Write("»юль"); break;
                    case 8: Console.Write("јвгуст"); break;
                    case 9: Console.Write("—ент€брь"); break;
                    case 10: Console.Write("ќкт€брь"); break;
                    case 11: Console.Write("Ќо€брь"); break;
                    case 12: Console.Write("ƒекабрь"); break;
                    default: Console.Write("нет такого мес€ца"); break;
                };
            }
            else 
            {
                Console.Write("¬ведите номер мес€ца");
            };
            Console.ReadKey();
        }
    }
}
