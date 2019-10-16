using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics1
{

    enum Direction {  north , south , east, west};
    class Program
    {

        static Direction mydir;
        static string mystring = " hello world";
        static char mychar = 'a';
        static char mychar1 = 'h';
        static int myint;
        static short myshort;
        static long mylong;
        static long mybool;
        static Double myDouble;
        static Decimal myDecimal;


        const int daysInweek = 7;


        static float myfloat;
        static void Main(string[] args)
        {
            //    Console.WriteLine(" hello world");
            //    Console.WriteLine(mystring  + mychar + mychar1);
            //    Console.WriteLine(myint);
            //    Console.WriteLine(myshort);
            //    Console.WriteLine(mylong);


            //    Console.WriteLine("max value for int :" + int.MaxValue);
            //    Console.WriteLine("max value for short"  + short.MaxValue);
            //    Console.WriteLine("max value for long :" + long.MaxValue);
            //    Console.WriteLine("max value for float :" + float.MaxValue);
            //    Console.WriteLine("max value for double :" + Double.MaxValue);


            //myfloat = 1f/ 7f;
            //myDouble = 1d / 7d;
            //myDecimal = 1m / 7m;


            //    Console.WriteLine(myfloat);
            //    Console.WriteLine(myDecimal);
            //    Console.WriteLine(myDouble);

            //int int1 = 100;
            //float float1 = int1;
            //float1  = float1 + 2.3f;
            //int1 = (int)float1;


            //int someint = int.MaxValue;

            //long somelong = someint;
            //somelong++;
            //Console.WriteLine(somelong);
            //someint = (int)somelong;
            //Console.WriteLine(someint);

            //int int1 = 2;
            //int int2 = 4;
            //int temp = int1;
            //int1 = int2;
            //int2 = temp;

            //Console.WriteLine("int1 =" + int1 + "int2 = " + int2);


            bool someBool = false;
            bool anotherBool = true;


            //if(someBool)
            //{
            //    Console.WriteLine(" someBool was true");

            //}
            //else
            //{

            //    Console.WriteLine(" someBool was flase");

            //}


            //if(someBool && anotherBool)
            //{

            //    Console.WriteLine(" someBool was false");
            //}


            //if (someBool || anotherBool)
            //{

            //    Console.WriteLine(" at least one was true");
            //}


            //if (!someBool)
            //{

            //    Console.WriteLine(" someBool was false");
            //}

            //string message = someBool ? " someBool was true " : " someBool was false ";
            //Console.WriteLine(message);

            //Console.WriteLine(mydir);
            //mydir = Direction.east;
            //Console.WriteLine(mydir);

            // mydir = (Direction)3;
            //// Console.WriteLine((int)mydir);


            //switch(mydir)
            // {

            //     case Direction.north:

            //         Console.WriteLine(" polar bears");
            //         break;
            //     case Direction.south:
            //         Console.WriteLine(" arif");
            //         break;
            //     case Direction.east:
            //         Console.WriteLine(" sun rise");
            //         break;
            //     case Direction.west:
            //         Console.WriteLine(" sun set");
            //         break;
            //     default:

            //         Console.WriteLine(" opps we hit default");
            //         break;


            // }

            //Console.WriteLine(" please enter y for 'yes' and n for 'no' , and aynthing else for maybe  ");
            //char inputchar = char.Parse(Console.ReadLine());
            //Console.WriteLine("inputchar = " + inputchar);




            //switch (inputchar)
            //{


            //    case 'y':
            //        Console.WriteLine("you selected yes !");
            //        break;
            //    case 'n':
            //        Console.WriteLine("you selected no !");
            //        break;

            //    default:
            //        Console.WriteLine("you selected maybe !");
            //        break;
            //}


            //string[] words = new string[]
            //{
            //    " shoe ",
            //    " leg ",
            //    " spr007"
            //};

            //// Console.WriteLine(words[2]);

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(words[i]);
            //}

            // bool sucessfulparse = false;
            // int input = 0;
            //sucessfulparse = int.TryParse(Console.ReadLine(), out input);
            // Console.WriteLine(input);


            //bool sucessfulparse = false;
            //int input = 0;
            //while (!sucessfulparse)
            //{
            //    Console.WriteLine("please enter an integer");
            //    sucessfulparse = int.TryParse(Console.ReadLine(), out input);
            //}
            //Console.WriteLine(input);
            //Console.ReadKey();


            bool sucessfulparse = false;
            int sizeofarray = 0;
            Console.WriteLine();
            while (!sucessfulparse)
            {
                Console.WriteLine("please enter an integer");
                sucessfulparse = int.TryParse(Console.ReadLine(), out sizeofarray);
            }
            int[] intarray = new int[sizeofarray];
            for (int i = 0; i < sizeofarray; i++)
            {
                Console.WriteLine("please enter the next int to put in the array");
                bool sucessful = false;

                int userint = 0;
                while (!sucessful)
                {
                    sucessful = int.TryParse(Console.ReadLine(), out userint);
                }

                intarray[i] = userint;
            }


            Console.WriteLine("please enter the size of array you like");
            int arraysize = 0;
            int sum = 0;
            float avg = 0;
            for (int i = 0; i <arraysize ; i++)
            {
                sum = sum + intarray[i];
            }
            Console.WriteLine("sum " + sum);
            for (int i = 0; i < arraysize; i++)
            {
                avg = sum / intarray.Length;

            }
            Console.WriteLine("avg" + avg);
            Console.ReadKey();

            //Console.WriteLine("herer are your ints");
            //foreach (int  i  in intarray)
            //{
            //    Console.WriteLine(i);
            //}
           


        }
        int num = 30;
        int factorial = 0;
        //this code sets "factorial equal to the factorial of " num
        Console.writeline(" the factorial of number is " + num )
    }
}



