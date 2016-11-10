using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c; // длины сторон треугольника
            double angleA, angleB, angleC; // углы треугольника 
            double perimeter; // Периметр
            double square; //Площадь

            if (double.TryParse(Console.ReadLine(), out a) && double.TryParse(Console.ReadLine(), out b) && double.TryParse(Console.ReadLine(), out c))
            {
                // проверка на существование треугольника
                if (((b + c) > a) && ((c + a) > a) && ((a + b) > c))
                {                    
                    if ((a == b) || (a == c) || (b == c)) 
                    {                        
                        Console.WriteLine("Равнобедренный треугольник.");                        
                        if ((a == b) && (b == c))
                        {
                            Console.WriteLine("Равноcторонницй треугольник.");
                        };
                    };

                    angleA = (Math.Acos((b * b + c * c - a * a) / (2 * b * c)))*(180 / Math.PI);
                    angleB = (Math.Acos((a * a + c * c - b * b) / (2 * a * c)))*(180 / Math.PI);
                    angleC = (180 - (angleA + angleB));

                    if ((angleA == 90) || (angleB == 90) || (angleC == 90)) { Console.WriteLine("Прямоуголиный треуголинк."); }
                    else
                    {
                        if ((angleA < 90) && (angleB < 90) && (angleC < 90)) { Console.WriteLine("Остроугольный треуголинк."); }
                        
                        else{
                            if ((angleA > 90) || (angleB > 90) || (angleC > 90)) { Console.WriteLine("Тупоуголиный треуголинк."); }
                        }
                    } 
                    
                    perimeter = a+b+c;
                    square = ((b * c) / 2) * (Math.Sin(Math.PI * angleA / 180.0));
                    if ((perimeter > 100) && (square > 200)) 
                    { 
                        Console.WriteLine("Треугольник очень большой");
                        
                    }
                    else 
                    {
                       if ((perimeter < 3) && (square < 1)) 
                       { 
                          Console.WriteLine("Треугольник очень маленький"); 
                       }
                    }
                    Console.WriteLine(" Периметр = " + perimeter + " \n Площадь = " + square);              
                }
                else 
                {
                    Console.WriteLine("Вырожденный треугольник."); 
                }             
            }
            else { Console.WriteLine("Неверное значение! Введите число."); }
            Console.ReadKey();
        }
    }
}
