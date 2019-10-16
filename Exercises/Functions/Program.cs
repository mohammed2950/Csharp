using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            //    DisplayMessage("Hello world");

            //    DisplayMessage(new string[] { "Hello world,", " this is arif" }, true);
            //    DisplayMessage(new string[] { "Hello world", "this is arif" }, false);
            //    GetUserInt("please enter an int between  5 and 10 ", 5, 10);
            int max = IntMax();
            DisplayMessage(IntMax(1, 2, 3, 4).ToString());
            int min = Intmin();
            DisplayMessage(Intmin(1, 2, 3, 4).ToString());
            Console.WriteLine(Average(2, 3));

            int Min = 0;
            int Max = 0;
            int Avg = 0;
            MinMaxAvg(out Min, out Max, out Avg, 3, 6, 9);
            int a = 3;
            int b = 4;
            swapInts(ref a, ref b);
            Console.WriteLine(+a + "," + b);

            Console.ReadLine();
        }

        #region Display Functions
        static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        static void DisplayMessage(string[] messages, bool singleLine)
        {
            if (singleLine)
            {
                foreach (string s in messages)
                {
                    Console.Write(s);
                }
                LineBreak(1);
            }
            else
            {
                foreach (string s in messages)
                {
                    Console.WriteLine(s);
                }
            }
        }

        static void LineBreak(int numOfBreaks)
        {
            for (int i = 0; i < numOfBreaks; i++)
            {
                Console.Write("\n");
            }

        }
        #endregion

        #region Get User Input Functions
        static string GetStringFromUser()
        {
            return Console.ReadLine();
        }

        static string GetStringFromUser(string message)
        {
            DisplayMessage(message);
            return GetStringFromUser();
        }

        static int GetUserInt(string message)
        {
            bool successfulParse = false;
            int toReturn;
            do
            {
                DisplayMessage(message);
                successfulParse = int.TryParse(Console.ReadLine(), out toReturn);
            }
            while (!successfulParse);
            return toReturn;
        }

        static int GetUserInt(string message, int min, int max = int.MaxValue)
        {
            bool successfulParse = false;
            int toReturn;
            do
            {
                DisplayMessage(message);
                successfulParse = int.TryParse(Console.ReadLine(), out toReturn);
            }
            while (!successfulParse || toReturn < min || toReturn > max);
            return toReturn;
        }




        static int Intmin(params int[] ints)
        {
            int minInt = int.MinValue;
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] < minInt)
                {
                    minInt = ints[i];
                }
            }
            return minInt;


        }
        static int IntMax(params int[] ints)
        {
            int maxInt = int.MinValue;
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] > maxInt)
                {
                    maxInt = ints[i];
                }
            }
            return maxInt;
        }

        static float Average(params int[] ints)
        {
            float Average = 0;

            return (float)sum(ints) / ints.Length;

        }

        static int sum(params int[] ints)
        {
            int toreturn = 0;
            for (int i = 0; i <= ints.Length; i++)
            {
                toreturn += ints[i];
            }
            return toreturn;
        }

        static void MinMaxAvg(out int min, out int max, out int avg, params int[] ints)
        {
            min = Intmin(ints);
            max = IntMax(ints);
            avg = Average(ints);
        }

        static void swapInts(ref int int1, ref int int2)
        {
            int temp = int1;
            int1 = int2;
            int2 = temp;
        }
    }
}

#endregion