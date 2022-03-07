using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Database database = new Oracle();
            database.Add();
            database.Update();

            Database database2 = new Oracle();
            database2.Add();
            database2.Update();

            Console.ReadLine();
        }
    }

    abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("Added by default");
        }
        public abstract void Update();
    }

    class SqlServer : Database
    {
        public override void Update()
        {
            Console.WriteLine("Delete by SqlServer");
        }
    }

    class Oracle : Database
    {
        public override void Update()
        {
            Console.WriteLine("Delete by Oracle");
        }
    }
}
