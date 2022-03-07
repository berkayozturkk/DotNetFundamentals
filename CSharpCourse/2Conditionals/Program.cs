using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 10;

            if (number == 10)
                Console.WriteLine("Sayi 10");
            else
                Console.WriteLine("Sayi {0}", number);

            Console.ReadLine();
        }
    }
}
