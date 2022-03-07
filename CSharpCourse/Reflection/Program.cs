using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //DortIslem dortIslem = new DortIslem(4,2);
            //Console.WriteLine(dortIslem.Carp(1, 1));
            //Console.WriteLine(dortIslem.Carp2());

            var type = typeof(DortIslem);

            //var type = typeof(DortIslem);
            //var dortIslem = (DortIslem)Activator.CreateInstance(type,6,7);
            //Console.WriteLine(dortIslem.Carp2());

            var instance = Activator.CreateInstance(type, 54, 2);

            MethodInfo methodInfo = instance.GetType().GetMethod("Topla2");
            Console.WriteLine(methodInfo.Invoke(instance, null));


            var methods = type.GetMethods();

            foreach (var method in methods)
            {
                Console.WriteLine("Methods name: {0}",method.Name);
                foreach (var parametreInfo in method.GetParameters())
                {
                    Console.WriteLine("Parametre: {0}", parametreInfo.Name);
                }

                foreach (var attribute in method.GetCustomAttributes())
                {
                    Console.WriteLine("Attribute Name: {0}" , attribute.GetType().Name);
                }
            }

            Console.ReadLine();
        }
    }

    class DortIslem
    {
        private int _sayi1;
        private int _sayi2;

        public DortIslem(int sayi1, int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }

        public int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }

        public int Topla2()
        {
            return _sayi1 + _sayi2;
        }

        [MethodName("Carpma")]
        public int Carp2()
        {
            return _sayi1 * _sayi2;
        }

        class MethodNameAttribute : Attribute
        {
            public MethodNameAttribute(String name)
            {
                    
            }
        }

    }
}
