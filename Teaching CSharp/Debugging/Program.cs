using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            //A1();
            //B1();
            int myInt = C1(3);
            //string myString = D1();
            //int test = 3;
            //E1(ref test);

            Console.WriteLine(GreatestDifference(intArray)); // this line does not return the correct value. try debugging it!
        }

        #region Nested Calls
        static void A1()
        {
            A2();
        }

        static void A2()
        {
            A3();
        }

        static void A3()
        {

        }
        #endregion
        #region Infinite Loop
        static void B1()
        {
            B2();
        }

        static void B2()
        {
            B1();
        }
        #endregion
        #region Nested Returns (int example)
        static int C1(int i)
        {
            int toReturn = C2(i + 1);
            return toReturn;
        }

        static int C2(int i)
        {
            int toReturn = C3(i * 3);
            return toReturn;
        }

        static int C3(int i)
        {
            int toReturn = i - 4;
            return toReturn;
        }
        #endregion
        #region Nested Returns (string example)
        static string D1()
        {
            string toReturn = D2("a");
            return toReturn + "f";
        }
        static string D2(string s)
        {
            string toReturn = D3(s + "b");
            return toReturn + "e";
        }
        static string D3(string s)
        {
            string toReturn = s + "c";
            return toReturn + "d";
        }
        #endregion
        #region Nested Reference
        static void E1(ref int i)
        {
            i++;
            E2(ref i);
        }
        static void E2(ref int i)
        {
            i *= i;
            E3(ref i);
        }
        static void E3(ref int i)
        {
            i--;
        }
        #endregion

        #region Bugged Code

        static int[] intArray = new int[] { 5, 3, 5, 8, 4, 2, 1 };

        static int MaxInt(int[] inputArray)
        {
            int max = int.MinValue;
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] > max)
                    max = inputArray[i];
            }
            return max;
        }

        static int MinInt(int[] inputArray)
        {
            int min = int.MaxValue;
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] < min)
                    min = inputArray[i];
            }
            return min;
        }

        static int GreatestDifference(int[] inputArray)
        {
            return MaxInt(inputArray) - MinInt(inputArray);
        }


        #endregion
    }

}
