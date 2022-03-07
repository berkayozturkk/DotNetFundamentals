using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(); 

            Person[] persons = new Person[]
            {
                new Customer{Name = "Berkay" },
                new Student{Name ="Emre"},
                new Person{Name ="Ece"}
            };
           
            foreach (Person person in persons)
            {
                Console.WriteLine(person.Name);
            }

            Console.ReadLine();
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }

    class Customer : Person
    {
        public string City { get; set; }
    }

    class Student : Person
    {
        public string Departmant { get; set; }
    }

}
