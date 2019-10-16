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
            //DisplayMessage("Hello world");

            //DisplayMessage(new string[] { "Hello world,", " this is Patrick.", " Is anybody out there?" }, true);
            //DisplayMessage(new string[] { "-hello world", "-this is Patrick", "-is anybody out there?" }, false);

            //DisplayMessage("Up Here");
            //LineBreak(10);
            //DisplayMessage("Down here");

            //string userString = GetStringFromUser();
            //DisplayMessage("You entered: " + userString);

            //DisplayMessage("You entered: " + GetStringFromUser("Please enter your name"));

            //int age = GetUserInt("Please enter your age");
            //int age = GetUserInt("Please enter your age", 0, 150);
            //int age = GetUserInt("Please enter your age", 0);
            //DisplayMessage("Your age: " + age);

            //bool userLikesCabbage = GetUserBool("Do you like cabbage?");
            //if (userLikesCabbage)
            //    DisplayMessage("me too!");
            //else
            //    DisplayMessage("hey, what's wrong with cabbage?");

            //string[] userStrings = GetUserStringArray("Please enter 3 strings", 3);
            //DisplayMessage("You entered the following strings:");
            //DisplayMessage(userStrings, false);

            //int[] arrayOfInts = GetUserIntArray("Creating array of 5 ints", 5);

            //DisplayMessage("The sum of your array is: " + IntSum(arrayOfInts));
            //DisplayMessage("The average of your array is: " + IntAverage(arrayOfInts));
            //DisplayMessage("The smallest value of your array is: " + IntMin(arrayOfInts));
            //DisplayMessage("The largest value of your array is: " + IntMax(arrayOfInts));

            //int total = IntSum(1, 2, 3, 4, 5);
            //DisplayMessage(total.ToString());

            //int minValue;
            //int maxValue;
            //float averageValue;

            //MinMaxAvgOfInts(out minValue, out maxValue, out averageValue, arrayOfInts);

            //DisplayMessage("Min: " + minValue + ", Max: " + maxValue + ", Average: " + averageValue);

            //SwapInts(ref minValue, ref maxValue);

            //DisplayMessage("Min after swap: " + minValue + ", Max after swap: " + maxValue);
        }

        #region Display Functions
        static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
        
        static void DisplayMessage(string[] messages, bool singleLine)
        {
            if(singleLine)
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

        static bool GetUserBool(string question)
        {
            char input = ' ';
            DisplayMessage(question);
            while(input != 'y' && input != 'n')
            {
                DisplayMessage("Please press y for yes or n for no");
                input = Console.ReadKey().KeyChar;
                LineBreak(1);
            }
            switch(input)
            {
                case 'y':
                    DisplayMessage("You selected Yes");
                    return true;
                case 'n':
                    DisplayMessage("You selected No");
                    return false;
                default:
                    DisplayMessage("Something went wrong - returning false");
                    return false;
            }
        }

        static string[] GetUserStringArray(string message, int arraySize)
        {
            string[] toReturn = new string[arraySize];
            DisplayMessage(message);
            for (int i = 0; i < toReturn.Length; i++)
            {
                toReturn[i] = GetStringFromUser("enter a string");
            }
            return toReturn;
        }

        static int[] GetUserIntArray(string message, int arraySize)
        {
            int[] toReturn = new int[arraySize];
            DisplayMessage(message);
            for (int i = 0; i < toReturn.Length; i++)
            {
                toReturn[i] = GetUserInt("Please enter an int");
            }
            return toReturn;
        }

        
        #endregion

        #region Operations On Ints

        static int IntSum(params int[] ints)
        {
            int sum = 0;
            foreach (int i in ints)
            {
                sum += i;
            }
            return sum;
        }
        static float IntAverage(params int[] ints)
        {
            return (float)IntSum(ints) / (float)ints.Length;
        }

        static int IntMax(params int[] ints)
        {
            int maxInt = int.MinValue;
            for(int i = 0; i < ints.Length; i++)
            {
                if (ints[i] > maxInt)
                {
                    maxInt = ints[i];
                }
            }
            return maxInt;
        }

        static int IntMin(params int[] ints)
        {
            int minInt = int.MaxValue;
            for (int i = 0; i < ints.Length; i++)
            {
                if(ints[i] < minInt)
                {
                    minInt = ints[i];
                }
            }
            return minInt;
        }

        static void MinMaxAvgOfInts(out int min, out int max, out float avg, params int[] ints)
        {
            min = IntMin(ints);
            max = IntMax(ints);
            avg = IntAverage(ints);
        }

        static void SwapInts(ref int int1, ref int int2)
        {
            int temp = int1;
            int1 = int2;
            int2 = temp;
        }
        #endregion

        #region Console Functions
        static void SetConsoleSettings(ConsoleColor backgroundColor, ConsoleColor foregroundColor, bool largeConsole, string title )
        {
            Console.BackgroundColor = backgroundColor;
            Console.ForegroundColor = foregroundColor;
            if(largeConsole)
                Console.SetWindowSize(Console.LargestWindowWidth - 20, Console.LargestWindowHeight - 5);
            Console.Title = title;
        }
        #endregion


    }
}
