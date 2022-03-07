using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 11;

            if (number == 10)
                Console.WriteLine("Sayi 10");
            else
                Console.WriteLine("Sayi {0}", number);

            Console.WriteLine(number == 10 ? "Number is 10" : "Number is not 10 ");
            
            switch (number)
            {
                case 10:
                    Console.WriteLine("number is 10");
                    break;
                case 11:
                    Console.WriteLine("numberr");
                    break;
                default:
                    Console.WriteLine("null");
                    break;
            }

            Console.ReadLine();
        }
    }
}

