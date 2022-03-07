using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(10);
            customerManager.List();

            EmployeeManager employeeManager = 
                new EmployeeManager(new DatabaseLogger());
            employeeManager.Add();

            PersonManager personManager = new PersonManager("product");
            personManager.Add();


            Manager.DoSomething();
            Manager manager = new Manager();
            manager.DoSomething2();

            Console.ReadLine();
        }
    }

    class CustomerManager
    {

        int ID;
        private int _count;

        public CustomerManager()
        {


        }
        public CustomerManager(int count)
        {
            this._count = count;
        }

        public void List()
        {
            Console.WriteLine("List {0} items", _count);
        }

        public void Add()
        {
            Console.WriteLine("Added");
        }

    }

    interface ILogger
    {
        void Log();
    }

    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Log to database");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Log to file");
        }
    }
    class EmployeeManager
    {
        ILogger Logger;

        public EmployeeManager(ILogger Logger)
        {
            this.Logger = Logger;
        }

        public void Add()
        {
            Logger.Log();
            Console.WriteLine("Added");
        }
    }

    class BaseClass
    {
        private string _entity;

        public BaseClass(string entity)
        {
            _entity = entity;
        }

        public void Message()
        {
            Console.WriteLine("{0} message",_entity);
        }
    }

    class PersonManager : BaseClass
    {
        public PersonManager(string entity) : base(entity)
        {

        }
        public void Add()
        {
            Console.WriteLine("Added");
            Message();
        }
    }

    static class Teacher
    {
        
    }

    class Manager
    {
        public static void DoSomething()
        {
            Console.WriteLine("Done");
        }

        public void DoSomething2()
        {
            Console.WriteLine("Done");
        }
    }
}

