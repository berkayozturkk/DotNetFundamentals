using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int number1 = 12;
            int number2 = 13;

            Add();
            Console.WriteLine(Sum(43, 45));
            Console.WriteLine(Sum(70));
            Console.WriteLine(Sum(number1,number2));
 //          Console.WriteLine(Add2(number1,number2));
 //          Console.WriteLine(Add2(out number1,number2));
            Console.WriteLine(Add4(3,4,123,1));

            int[] sayilar = new int[6];

            for (int i = 0; i<sayilar.Length; i++)
            {
                sayilar[i] = i*2;
                Console.WriteLine(sayilar[i]);
            }
            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("is Add()");
        }

        static int Sum(int number1,int number2 = 30)
        {
            return number1 + number2;
           
        }

        //ref
        static int Add2(ref int number1, int number2 = 30)
        {
            number1 = 20;
            return number1 + number2;
        }

        static int Add3(out int number1, int number2 = 30)
        {
            number1 = 20;
            return number1 + number2;
        }

        static int Add4(params int[] numbers)
        {
           return numbers.Sum();
        }

    }
}
