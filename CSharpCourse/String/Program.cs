using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "My name is Berkayyy";

   //         Console.WriteLine(sentence.Length);

            var result = sentence.Clone();
            sentence = "Berkayy";
            Console.WriteLine(sentence);
            Console.WriteLine(result);

            bool control = sentence.EndsWith("y");
            bool control2 = sentence.StartsWith("Be");
            Console.WriteLine(control);
            Console.WriteLine(control2);

            var resualt = sentence.IndexOf("r");
            var resualt2 = sentence.IndexOf(" ");
            Console.WriteLine(resualt);
            Console.WriteLine(resualt2);

            Console.ReadLine();
        }

        static void String1()
        {
            string name = "Berkay";
            Console.WriteLine(name[0]);
            Console.WriteLine(name);

            foreach (Object arg in name)
            {
                Console.WriteLine(arg);
            }

            Console.ReadLine();
        }
    }
}
