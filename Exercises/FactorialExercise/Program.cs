using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Enter the number:");
            int num = getIntInput();
            Console.WriteLine(factorial(num));
            Console.ReadLine();
        }
        static int getIntInput()
        {

            
            int getIntinput = int.Parse(Console.ReadLine());
            return getIntinput;

        }
       
        static int factorial(int num)
        {

            int fact = 1;
            Console.Write("Enter any Number: ");

            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }
            return fact;

        }

    }
}



