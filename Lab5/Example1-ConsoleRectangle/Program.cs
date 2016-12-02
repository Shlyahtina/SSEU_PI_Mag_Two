using System;
using System.Collections.Generic;
using System.Text;

namespace Example1_ConsoleRectangle
{

    class Rectangle 
    {
        public double x1, y1;//верхний левый угол
        public double x2, y2;// правый нижний угол

        public Rectangle(double x1, double y1, double x2, double y2)
        { 
            this.x1 = x1; this.y1 = y1;
            this.x2 = x2; this.y2 = y2;
        }
        // ширина
        public double width(){return Math.Abs(x2-x1);}
        // высота
        public double height(){return Math.Abs(y2 - y1);}
        // периметр
        public double p(){return 2*(width()+height());}
        // площадь 
        public double s(){return width()*height();}
        //квадрат
        public bool isSquare() { return width() == height();}

        //перемещение
        public void move(double x, double y)
        {
            x1 += x; x2 += x;
            y1 += y; y2 += y;
        }

        //изменить ширину 
        public void setWidth(double newWidth)
        {
            x2 = x1 + newWidth;
        }

        //изменить высоту 
        public void setHeight(double newHeight)
        {
            y2 = y1 + newHeight;
        }

    }


    class Program
    {
        static double readCoord(string message)
        {
            double coord;
            Console.Write("Введите координату" + message);
            while (!double.TryParse(Console.ReadLine(), out coord))
            {
                Console.Write("Ошибка! Введите число.");
            };
            return coord;
        }

        static void Main(string[] args)
        {
            Rectangle r;
            Console.WriteLine("Создание прямоугольника.");

            r = new Rectangle(readCoord(" - x верхнего левого угла "),
                              readCoord(" - y верхнего левого угла "),
                              readCoord(" - x нижнего правого угла "),
                              readCoord(" - y нижнего правого угла "));
            char key;
            do
            {
                Console.Clear();
                Console.WriteLine("\t\t         ПРЯМОУГОЛЬНИК");

                Console.WriteLine("Верхний левый угол: x = " + r.x1 + ", y = " + r.y1);
                Console.WriteLine("Нижний правый угол: x = " + r.x2 + ", y = " + r.y2);

                Console.WriteLine("Ширина = " + r.width());
                Console.WriteLine("Высота = " + r.height());
                
                Console.WriteLine("Периметр = " + r.p());
                Console.WriteLine("Площадь = " + r.s());

                //меню
                Console.WriteLine("\t\t╔════════════════════════════╗");
                Console.WriteLine("\t\t║            МЕНЮ            ║");
                Console.WriteLine("\t\t║ a - является ли квадратом? ║");
                Console.WriteLine("\t\t║ b - переместить            ║");
                Console.WriteLine("\t\t║ c - изменить ширину        ║");
                Console.WriteLine("\t\t║ d - изменить высоту        ║");
                Console.WriteLine("\t\t║ ESC - выход                ║");
                Console.WriteLine("\t\t╚════════════════════════════╝");

                key = Console.ReadKey().KeyChar;

                switch (key)
                {
                    case'a':
                        Console.Clear();
                        if (r.isSquare())
                            Console.WriteLine("Квадрат (" + r.width() + " = " + r.height() + ")");
                        else
                            Console.WriteLine("Не квадрат (" + r.width() + " != " + r.height() + ")");
                            Console.WriteLine("Нажмите любую клавишу");
                            Console.ReadKey();
                   break;

                    case 'b'://перемещение
                   Console.Clear();
                   r.move(readCoord("по x"), readCoord("по y"));
                   Console.WriteLine("Нажмите любую клавишу");
                   Console.ReadKey();
                   break;

                    case 'c': //изменить ширину
                   Console.Clear();
                   Console.WriteLine("Какую установить ширину?");
                   r.setWidth(readCoord(""));
                   Console.WriteLine("Нажмите любую клавишу");
                   Console.ReadKey();
                   break;

                    case 'd': //изменить высоту
                   Console.Clear();
                   Console.WriteLine("Какую установить высоту?");
                   r.setHeight(readCoord(""));
                   Console.WriteLine("Нажмите любую клавишу");
                   Console.ReadKey();
                   break;     


                };
            }
            while (key != (char)27); // Esc4
        }
    }
}
