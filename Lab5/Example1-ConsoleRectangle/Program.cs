using System;
using System.Collections.Generic;
using System.Text;

namespace Example1_ConsoleRectangle
{

    class Rectangle 
    {
        public double x1, y1;//������� ����� ����
        public double x2, y2;// ������ ������ ����

        public Rectangle(double x1, double y1, double x2, double y2)
        { 
            this.x1 = x1; this.y1 = y1;
            this.x2 = x2; this.y2 = y2;
        }

        public double Width() 
        { 
            return Math.Abs(x2-x1);
        }

        public double Height()
        {
            return Math.Abs(y2 - y1);
        }

        public double P()
        {
            return 2*(Width()+Height());
        }

        public double S()
        {
            return Width()*Height();
        }
    }


    class Program
    {
        static double ReadCoord(string message)
        {
            double coord;
            Console.Write("������� ����������" + message);
            while (!double.TryParse(Console.ReadLine(), out coord))
            {
                Console.Write("������! ������� �����.");
            };
            return coord;
        }

        static void Main(string[] args)
        {
            Rectangle r;
            Console.WriteLine("�������� ��������������.");

            r = new Rectangle(ReadCoord("x �������� ������ ����"),
                              ReadCoord("y �������� ������ ����"),
                              ReadCoord("x ������� ������� ����"),
                              ReadCoord("y ������� ������� ����"));
            char key;
            do
            {
                Console.Clear();
                Console.WriteLine("\t\t         �������������");

                Console.WriteLine("������� ����� ����: x = " + r.x1 + ", y = " + r.y1);
                Console.WriteLine("������ ������ ����: x = " + r.x2 + ", y = " + r.y2);

                Console.WriteLine("������ = " + r.Width());
                Console.WriteLine("������ = " + r.Height());
                
                Console.WriteLine("�������� = " + r.P());
                Console.WriteLine("������� = " + r.S());

                key = Console.ReadKey().KeyChar;
            }
            while (key != (char)27); // Esc
        }
    }
}
