using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            double ruble = 1;   // 1 рубль = 1 рублей
            double еuro = 70.6; // 1 евро = 70,6 рублей
            double dollars = 63.5; // 1 доллар = 63,5 рублей
            double pounds = 74.43; // 1 фунт = 74,43 рублей
            double yen = 0.6174; // 1 йен = 0,6174 рублей



            String currencyEnter;
            String currencyConclusion;
            double summaEnter = 0;
            double summaResult = 0; 
            double summaBufferRubl = 0;

            Console.WriteLine("Введите сумму");

            if (double.TryParse(Console.ReadLine(), out summaEnter))
            {

                Console.WriteLine("Выберете валюту из которой надо переводить \n   ruble,   еuro,   dollars,   pounds,   yen");               
                currencyEnter = Console.ReadLine();


     
                    //перевод из любой волюты в рубли
                    switch (currencyEnter)
                    {
                        case "ruble": summaBufferRubl = summaEnter * ruble; break;
                        case "euro": summaBufferRubl = summaEnter * еuro; break;
                        case "dollars": summaBufferRubl = summaEnter * dollars; break;
                        case "pounds": summaBufferRubl = summaEnter * pounds; break;
                        case "yen": summaBufferRubl = summaEnter * yen; break;
                        default: Console.WriteLine("Выберете валюту из предложенных"); break;
                            
                        // перевод из руболй в любую другую валюту
                           

                    };

                    Console.WriteLine("Выберете валюту в которую надо переводить \n  ruble,   еuro,  dollars,   pounds,   yen");
                    currencyConclusion = Console.ReadLine();  

                    switch (currencyConclusion)
                    {
                        case "ruble": summaResult = summaBufferRubl / ruble; break;
                        case "euro": summaResult = summaBufferRubl / еuro; break;
                        case "dollars": summaResult = summaBufferRubl / dollars; break;
                        case "pounds": summaResult = summaBufferRubl / pounds; break;
                        case "yen": summaResult = summaBufferRubl / yen; break;
                        default: Console.WriteLine("Выберете валюту из предложенных"); break;

                    };

                    Console.WriteLine(summaEnter + " " + currencyEnter + " --> " + Math.Round(summaResult, 2, MidpointRounding.AwayFromZero) + "  " + currencyConclusion);
            }
            else
            {
                Console.WriteLine("Введеная сумма должна быть числом!");
            };
            Console.ReadKey();           
        }
    }
}
