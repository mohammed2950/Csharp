using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static int[] myIntArray = new int[] { 3, 6, 7 };
        static int myInt;

        static void Main(string[] args)
        {
            //myInt = myIntArray[5];
            //Console.WriteLine("myInt = " + myInt);

            //try
            //{
            //    int myInt = myIntArray[5];
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Exception was thrown while setting myInt; setting myInt equal to 0 ");
            //    myInt = 0;
            //}
            //Console.WriteLine("myInt = " + myInt);

            //try
            //{
            //    int myInt = myIntArray[5];
            //}
            //catch (IndexOutOfRangeException e)
            //{
            //    Console.WriteLine("IndexOutOfRangeException was thrown while setting myInt; setting myInt equal to 0 ");
            //    myInt = 0;
            //}
            //Console.WriteLine("myInt = " + myInt);

            //try
            //{
            //    myInt = int.Parse(Console.ReadLine());
            //}
            //catch (IndexOutOfRangeException e)
            //{
            //    Console.WriteLine("IndexOutOfRangeException was thrown while setting myInt; setting myInt equal to 0 ");
            //}
            //Console.WriteLine("myInt = " + myInt);

            //try
            //{
            //    int myInt = int.Parse(Console.ReadLine());
            //}
            //catch (FormatException e)
            //{
            //    Console.WriteLine(e);
            //}
            //Console.WriteLine("myInt = " + myInt);


            float myFloat = 0f;

            //myFloat = Divide(1f, 0f);
            //Console.WriteLine("myFloat = " + myFloat);

            try
            {
                myFloat = Divide(1f, 0f);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("myFloat = " + myFloat);
        }



        static float Divide(float numerator, float denominator)
        {
            if (denominator == 0)
            {
                throw new DivideByZeroException();
            }
            return numerator / denominator;
 
        }
    }

    class DivideByZeroException : Exception
    {
        public DivideByZeroException() : base("Division by zero occurred") { }
    }

}
