using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product hardDisk = new Product(50);
            Product GSM = new Product(50);

            GSM.StockControlEvent += Gsm_StockControlEvent;




            for (int i = 0; i < 10; i++)
            {
                hardDisk.Sell(10);
                GSM.Sell(10);
                Console.ReadLine();
            }

            Console.ReadLine();
        }

        private static void Gsm_StockControlEvent()
        {
            Console.WriteLine("Gsm about to finish");
        }
    }


}
