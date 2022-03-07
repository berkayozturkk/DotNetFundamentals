using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer {Id = 1, Name = "Berkay", Age=21 };
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);

            Console.ReadLine();
        }
    }


    class Customer
    {
        public int Id { get; set; }
        [RequiredProperty]
        public string Name { get; set; }
        [RequiredProperty]
        public int Age { get; set; }
    }

    [AttributeUsage(AttributeTargets.All,AllowMultiple = true)]
    class RequiredPropertyAttribute : Attribute
    {

    }


    class CustomerDal
    {
        [Obsolete("Dont use Add,instead use AddNew()")]
        public void Add(Customer customer)
        {
            Console.WriteLine("{0},{1},{2} added!", customer.Id, customer.Name
                , customer.Age);
        }

        public void AddNew(Customer customer)
        {
            Console.WriteLine("{0},{1},{2} added!", customer.Id, customer.Name
                , customer.Age);
        }


    }


}
