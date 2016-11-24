using System;
using System.Collections.Generic;
using System.Text;

namespace Example1_FIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ââåäèòå èìÿ ");
            string name = Console.ReadLine();
            Console.Write("Ââ îò÷åñòâî ");
            string otchestvo =Console.ReadLine();
            Console.Write("Ââ ôàìèëèþ ");
            string lasName = Console.ReadLine();
            //1
            if (!string.IsNullOrEmpty(otchestvo)) { Console.WriteLine(name[0] + "." + otchestvo[0] + "." + lasName); }
            else { Console.WriteLine(name[0] + "." + lasName); };
            //2
            if (!string.IsNullOrEmpty(otchestvo))
            {
                Console.WriteLine(name[0].ToString().ToUpper() + "."
                                + otchestvo[0].ToString().ToUpper() + "."
                                + lasName[0].ToString().ToUpper()
                                + lasName.Substring(1).ToLower());
            }
            else 
            {
                Console.WriteLine(name[0].ToString().ToUpper() + "."
                                + lasName[0].ToString().ToUpper()
                                + lasName.Substring(1).ToLower());
            }
            //3
            if (!string.IsNullOrEmpty(otchestvo))
            {
                Console.WriteLine(lasName[0].ToString().ToUpper()
                                + lasName.Substring(1).ToLower() + "."
                                + name[0].ToString().ToUpper() + "."
                                + otchestvo[0].ToString().ToUpper() + ".");
            }
            else 
            {
                Console.WriteLine(lasName[0].ToString().ToUpper()
                                + lasName.Substring(1).ToLower() + "."
                                + name[0].ToString().ToUpper() + ".");
            }
            //4
            if (!string.IsNullOrEmpty(otchestvo))
            {
                Console.WriteLine(name[0].ToString().ToUpper() 
                                + name.Substring(1).ToLower() + " "
                                + otchestvo[0].ToString().ToUpper()
                                + otchestvo.Substring(1).ToLower() + " "
                                + lasName.ToUpper());
            }
            else
            {
                Console.WriteLine(name[0].ToString().ToUpper() 
                              + name.Substring(1).ToLower() + " "
                              + lasName.ToUpper());
            };
            //5
            if (!string.IsNullOrEmpty(otchestvo))
            {
                Console.WriteLine((lasName.Substring(0, 3) + "_"
                    + name.Substring(0, 1) + "_"
                    + otchestvo.Substring(0, 1)).ToLower());
            }
            else
            {
                Console.WriteLine((lasName.Substring(0, 3) + "_"
                 + name.Substring(0, 1)).ToLower());
            };

        }
    }
}
