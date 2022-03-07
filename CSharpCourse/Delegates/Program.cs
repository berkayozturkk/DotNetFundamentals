using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void MyDelegate();
    public delegate void MyDelegate2(string text);
    public delegate int MyDelegate3(int number1, int number2);

    internal class Program
    {
        static void Main(string[] args)
        {

            CustomerManager customerManager = new CustomerManager();
            //customerManager.ShowAlert();
            //customerManager.SendMessage();

            MyDelegate myDelegate = customerManager.SendMessage;
            myDelegate += customerManager.ShowAlert;
            myDelegate -= customerManager.ShowAlert;

            myDelegate();


            MyDelegate2 myDelegate2 = customerManager.SendMessage;
            myDelegate2 += customerManager.ShowAlert;

            myDelegate2("hello");
            
            Math math = new Math();
            MyDelegate3 myDelegate3 = math.Topla;
            var donus = myDelegate3(43,1);
            Console.WriteLine(donus);



            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello");
        }

        public void ShowAlert()
        {
              Console.WriteLine("is SwowAlert");
        }

        public void SendMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void ShowAlert(string alert)
        {
            Console.WriteLine(alert);
        }
    }

    class Math
    {
        public int Topla(int number1, int number2)
        {
            return number1 + number2;
        }

    }

    
}
