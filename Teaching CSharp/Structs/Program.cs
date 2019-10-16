using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    class Program
    {

        static void Main(string[] args)
        {

            //Merchandise m1;
            ////m1.Display();
            //m1.item = "t-shirt";
            ////m1.Display();
            //m1.price = 15f;
            //m1.Display();

            //Merchandise m2 = new Merchandise();
            //m2.Display();
            //m2.item = "frying pan";
            //m2.price = 21f;
            //m2.Display();

            //Merchandise m3 = new Merchandise("laptop", 899.99f);
            //m3.Display();

            DateTime dateTime1 = new DateTime(1999, 3, 15, 12, 45, 0);
            //Console.WriteLine("dateTime1: " + dateTime1);
            DateTime dateTime2 = dateTime1;
            //Console.WriteLine("dateTime2: " + dateTime2);
            dateTime1 = dateTime1.AddYears(1);
            Console.WriteLine("dateTime1: " + dateTime1);
            Console.WriteLine("dateTime2: " + dateTime2);

            
        }
    }
}
