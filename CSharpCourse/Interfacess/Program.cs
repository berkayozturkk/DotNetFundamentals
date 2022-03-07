using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfacess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonManager personManager = new PersonManager();
            personManager.Add(new Customer { Id = 1, Name = "Berkay", Address = "İstanbul" });
            
            Console.ReadLine();
        }
    }

    interface IPerson
    {
       int Id { get; set; }
       string Name { get; set; }
    }

    class Customer : IPerson
    {
 
        public int Id { get; set; }
        public string Name { get; set; }

        public string Address { get; set; }
    }

    class Student:IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Departmant { get; set; }
    }

    class PersonManager
    {
         public void Add(Customer customer)
        {
            Console.WriteLine(customer.Name);
        }
    }
}
