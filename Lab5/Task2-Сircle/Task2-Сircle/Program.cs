using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_Сircle
{
    class Сircle 
    {
        public bool flag = false;
        public double xC, yC;//центр окружности
        public double r;// радиус

        public Сircle(double x1, double y1, double r)
        { 
            this.xC = x1; this.yC = y1;
            this.r = r;
        }

        // периметр
        public double p() { return 2 * Math.PI * r; }
        // площадь 
        public double s() { return Math.PI * r * r; }

        //перемещение
        public void move(double x, double y)
        {
            xC += x; yC += y; 

        }

        //уменьшить площать в n раз
        public void reductionS(double n)
        {
            double newS =  s() / n;
            r = Math.Sqrt(newS / Math.PI);
        }

        // точка входит в окружность?
        public bool belongCircle(double poinX, double pointY)
        {
            flag = (((Math.Pow((poinX - xC), 2)) + (Math.Pow((pointY - yC), 2))) <= Math.Pow(r, 2));
            return flag;
        }

        
    }

    
    
    class Program
    {
        static double readCoord(string message)
        {
            double coord;
            Console.Write("Введите координату " + message);
            while (!double.TryParse(Console.ReadLine(), out coord))
            {
                Console.Write("Ошибка! Введите число.");
            };
            return coord;
        }

        static void Main(string[] args)
        {
            Сircle circle;
            Console.WriteLine("Создание окружности.");

            circle = new Сircle(readCoord(" - x центра окружности "),
                                readCoord(" - y центра окружности "),
                                readCoord(" - r радиус окружности "));
            char key;
            do
            {
                Console.Clear();
                Console.WriteLine("\t\t         ОКРУЖНОСТЬ");

                Console.WriteLine("Центр окружности координаты: x = " + circle.xC + ", y = " + circle.yC);
                Console.WriteLine("Радиус окружности: r = " + circle.r );

                Console.WriteLine("Периметр = " + circle.p());
                Console.WriteLine("Площадь = " + circle.s());

                //меню
                Console.WriteLine("\t\t╔════════════════════════════╗");
                Console.WriteLine("\t\t║            МЕНЮ            ║");               
                Console.WriteLine("\t\t║ a - переместить            ║");
                Console.WriteLine("\t\t║ b - уменьшить площадь      ║");
                Console.WriteLine("\t\t║ с - точка принадлежит?     ║");
                Console.WriteLine("\t\t║ ESC - выход                ║");
                Console.WriteLine("\t\t╚════════════════════════════╝");

                key = Console.ReadKey().KeyChar;

                switch (key)
                {
 
                    case 'a'://перемещение
                        Console.Clear();
                        circle.move(readCoord(" по x"), readCoord(" по y"));
                        Console.WriteLine("Нажмите любую клавишу");
                        Console.ReadKey();
                        break;

                    case 'b': //Во сколько раз уменьшить площать
                        Console.Clear();
                        Console.WriteLine("Во сколько раз уменьшить площать?");
                        circle.reductionS(readCoord(""));
                        Console.WriteLine("Нажмите любую клавишу");
                        Console.ReadKey();
                        break;

                    case 'c': //Точка входить в окружность
                        Console.Clear();
                        Console.WriteLine("Точка входить в окружность?");
                        circle.belongCircle(readCoord(" по x"), readCoord(" по y"));
                        if (circle.flag)
                        {
                            Console.WriteLine("Точка входит в окружность");
                        }
                        else { Console.WriteLine("Точка не входит в окружность"); }
                        Console.WriteLine("Нажмите любую клавишу");
                        Console.ReadKey();
                        break;


                };
            }
            while (key != (char)27); // Esc4
        }
    }
}
