using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList();
            //ArrayListIslemler();

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("computer", "bilgisayar");

            Console.WriteLine(dictionary["computer"]);

            //
            Console.ReadLine();
        }

        private static void ArrayListIslemler()
        {
            List<string> cities = new List<string>();
            cities.Add("Selam");

            List<Customer> customer = new List<Customer> {
                new Customer { Name = "Ece"},
                new Customer { Name = "Berkay"}
            };



            var customer2 = new Customer { Name = "ege" };
            customer.Add(customer2);
            customer.AddRange(new Customer[2]
            {
                new Customer { Name = "Ali"},
                new Customer { Name = "Engin"}
            });



            foreach (Customer c in customer)
            {
                Console.WriteLine(c.Name);
            }

            //customer.Clear();
            var count = customer.Count();
            Console.WriteLine(count);
        }

        private static void ArrayList()
        {
            ArrayList cities = new ArrayList();
            cities.Add("İstanbul");
            cities.Add("Tokat");
            cities.Add("Ordu");
            cities.Add(45);
            cities.Add('a');

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
        }
    }

    class Customer
    {
        public string Name { get; set; }
    }
}
