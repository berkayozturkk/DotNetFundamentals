using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SqlServer sqlServer = new SqlServer();
            MySql mySql = new MySql();

            sqlServer.Add();
            mySql.Add();

            Console.ReadLine();
        }
    }

    class Database
    {
        public virtual void Add()
        {
            Console.WriteLine("Added by default");
        }

        public void Delete()
        {
            Console.WriteLine("Deleted by default");
        }
    }

    class MySql : Database
    {
        public override void Add()
        {
            Console.WriteLine("Added MySql");
   //       base.Add();
        }
    }

    class SqlServer : Database
    {

    }
}
