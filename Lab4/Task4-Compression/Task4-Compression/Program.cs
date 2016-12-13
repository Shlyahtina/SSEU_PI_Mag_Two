using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_Compression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string strIn = Console.ReadLine(), strRez = "";
            char c = strIn[0];
            strRez += c;
            int len = 1;

            for (int i = 1; i < strIn.Length; i++)
                if (c == strIn[i])
                    len++;
                else
                {
                    c = strIn[i];
                    strRez += string.Format("{0}{1}", len, c);
                    len = 1;
                }
            strRez += string.Format("{0}", len);
            if (strRez.Length > strIn.Length) strRez = strIn;
            Console.WriteLine(strRez);
            Console.ReadLine();
        }
    }
}
