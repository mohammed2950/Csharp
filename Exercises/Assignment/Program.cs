using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            divisible(10, 5);


        }
        static bool divisible(int a, int b)
        {

            bool divisible = false;
            if (a % b == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool Primecheck(int numtocheck)
        {
            bool toReturn = true;
            for (int i = numtocheck / 2; i > 1; i--)
            {
                if (divisible(numtocheck, i))
                {
                    return false;
                }

            }
            return true;
        }
        static int GetUserInt(string message, int min, int max = int.MaxValue)
        {
            bool successfulParse = false;
            int toReturn;
            do
            {
                //DisplayMessage(message);
                successfulParse = int.TryParse(Console.ReadLine(), out toReturn);
            }
            while (!successfulParse || toReturn < min || toReturn > max);
            return toReturn;
        }

        static void printallprime(int n)
        {
            for (int i = n; i > 1; i--)
            {

                if

                    (Primecheck(i))
                    Console.WriteLine(i);

            }
        }
        static int[] createuserintArray(int size)
        {
            int[] toReturn = new int[size];

            for (int i = 0; i < toReturn.Length; i++)
            {
                toReturn[i] = GetUserInt("please enter an int to go in array");

            }

        }
        static bool CpmpareIntArrays(int[] array1, int[] array2)
        {
            if (array1.Length == array2.Length)
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    if (array1[i] != array2[i])
                        return false;

                }
                return true;
            }
            else
                return false;
        }
    }


