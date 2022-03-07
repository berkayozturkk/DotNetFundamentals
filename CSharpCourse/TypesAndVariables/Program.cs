using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            bool control = true;

            var number777 = 10;
            number777 = 'A';
            //          number777 = "A";

            Console.WriteLine(number777);
            Console.WriteLine("Number 1 is {0}", number1);
            Console.WriteLine(control);
            Console.WriteLine((int)Days.Friday);
            Console.WriteLine(Days.Friday);
            Console.ReadLine();

        }
    }

    enum Days
    {
        Monday, Teusday, Wendsday, Thursday, Friday
    }
}
