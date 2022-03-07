using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = { "Berkay", "Öztürk", "Junior C# Developer" };
            
            foreach (string student in students)
            {
                Console.WriteLine(student);
            }

            string[,] regions = new string[4, 3]
            {
                { "İstanbul","İzmir","Tekirdağ"},
                { "İzmir","Muğla","Manisa"},
                { "Trabzon","Ordu","Tokat"},
                { "Konya","Sivas","Ankara"}
            };

            for (int i = 0; i < regions.GetLength(0); i++)
            {
                for (int j = 0; j < regions.GetLength(1); j++)
                {
                    Console.Write(regions[i,j]);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
