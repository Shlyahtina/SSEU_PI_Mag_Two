using System;
using System.Collections.Generic;
using System.Text;

namespace Example1_FIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("¬ведите им€ ");
            string name = Console.ReadLine();
            Console.Write("¬в отчество ");
            string otchestvo =Console.ReadLine();
            Console.Write("¬в фамилию ");
            string lasName = Console.ReadLine();
            Console.WriteLine(name[0] + "." + otchestvo[0] + "." + lasName);

            Console.WriteLine(name[0].ToString().ToUpper() + "."
                            + otchestvo[0].ToString().ToUpper() + "."
                            + lasName[0].ToString().ToUpper()
                            + lasName.Substring(1).ToLower());

            Console.WriteLine(lasName[0].ToString().ToUpper()
                            + lasName.Substring(1).ToLower()+"."
                            + name[0].ToString().ToUpper() + "."
                            + otchestvo[0].ToString().ToUpper() + ".");

            Console.WriteLine(name[0].ToString().ToUpper() + "."
                            + name.Substring(1).ToLower() + " "
                            + otchestvo[0].ToString().ToUpper()
                            + otchestvo.Substring(1).ToLower() + " "
                            + lasName.ToUpper());

            Console.WriteLine((lasName.Substring(0,3)+"_"
                +name.Substring(0,1)+"_"
                +otchestvo.Substring(0,1)).ToLower());   
                            


        }
    }
}
