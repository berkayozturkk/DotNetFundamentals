using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            Console.WriteLine(customerManager.ToString());
            Console.WriteLine(customerManager.GetType());

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.Name = "Berkay";

            Customer customer1 = new Customer()
            {
                Id = 2,
                Name = "Berkay",
                City = "İstanbul"
            };

            Console.WriteLine(customer1.Name);

            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        public void Add()
        {
            Console.WriteLine("Costumer Added");
        }

        public void Update()
        {
            Console.WriteLine("Customer Update");
        }
    }

    class ProductManager
    {
        public void Add()
        {
            Console.WriteLine("Produc Added");
        }

        public void Update()
        {
            Console.WriteLine("Produc Update");
        }

    }
}
