using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };

            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEat[] eats = new IEat[2]
            {
                new Manager(), new Worker()
            };
        }
    }

    interface IWorker
    {
        void Work();
    }

    interface IEat
    {
        void Eat();
    }

    interface ISalary
    {
        void GetSalary();
    }

    class Manager : IWorker,IEat,ISalary
    {
        public void Eat()
        {
 
        }

        public void GetSalary()
        {

        }

        public void Work()
        {

        }
    }

    class Worker : IWorker,ISalary,IEat
    {
        public void Eat()
        {

        }

        public void GetSalary()
        {

        }

        public void Work()
        {
     
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {

        }
    }
}
