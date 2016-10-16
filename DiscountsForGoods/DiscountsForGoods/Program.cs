using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountsForGoods
{
    class Program
    {
        static void Main(string[] args)
        {
            int summ;
            int ONE_THOUSAND = 1000; // условие, больше данного числа давать скидку.
            int DISCOUNT = 15; // скидка 15 процентов
            Console.WriteLine("Введите сумму покупки:");
            if (int.TryParse(Console.ReadLine(), out summ))
            {
                if (summ > ONE_THOUSAND)
                {
                    double valueDiscount = (summ * DISCOUNT) / 100;
                    double result = summ - valueDiscount;
                    Console.WriteLine("Ваша скидка составляет:" + valueDiscount);
                    Console.WriteLine("Сумма к оплате со скидкой:" + result);
                }
                else { Console.WriteLine("Сумма покупки меньше тясячи, вам не предоставляется скидка. Извините."); }

            }
            else {Console.WriteLine("Неверное значение! Введите число."); }
            Console.ReadKey();
        }
    }
}
