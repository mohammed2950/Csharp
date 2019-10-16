using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Language_Fundamentals
{
    enum Direction { North, South, East, West };
    class Program
    {
        static char myChar; //stores a single character, like 'c'
        static string myString; //stores a string of characters, like "hello, my name is braden."

        static int myInt; //stores an integer like 12
        static short myShort; //stores an integer, but with less memory usage than the int type
        static long myLong; //stores an integer, but with more memory usage than the int type

        static double myDouble; //stores a real number, like 126.223
        static float myFloat; //stores a real number, but with less decimal precision (and memory usage) than the double type
        static decimal myDecimal; //stores a real number, but with more decimal precision (and memory usage) than the double type

        static bool myBool; //stores a boolean value: either true or false

        const int numOfDaysInWeek = 7;
        static Direction currentDirection;
        static string[] words;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(myString);
            Console.WriteLine(myInt);
            Console.WriteLine(myDouble);
            Console.WriteLine(myBool);

            Console.ReadLine();
            //myString = "Hello World";
            //Console.WriteLine(myString);
            //myChar = '!';
            //myString = myString + myChar; //strings and chars can be concatenated with the '+' operator
            //Console.Writeline(mystring);

            //myString = Console.ReadLine();
            //Console.Writeline("you entered the following string: " + mystring); //strings can be concatenated together with the '+' operator

            //Console.WriteLine("Min and Max values for the int type: " + int.MinValue + ", " + int.MaxValue); //different interger types have different min and max values due to their various memory size
            //Console.WriteLine("Min and Max values for the short type: " + short.MinValue + ", " + short.MaxValue);
            //Console.WriteLine("Min and Max values for the long type: " + long.MinValue + ", " + long.MaxValue);


            //myFloat = 1f / 7f; //different floating point types have different precision & range due to their various memory sizes
            //myDouble = 1d / 7d;
            //myDecimal = 1m / 7m;
            //Console.WriteLine(myFloat);
            //Console.WriteLine(myDouble);
            //Console.WriteLine(myDecimal);

            //int int1 = 100;
            //float float1 = int1; //implicit casting
            //int1 = float1; //error because an explicit cast is required. add "(int)"
            //Console.WriteLine(int1);
            //float1 += 2.3f;
            //Console.WriteLine(float1);
            //int1 = (int)float1; //information can be lost when casting from more precise to less precise types
            //Console.WriteLine(int1);
            //int1 = (int)"hello"; //not all simple types can be cast into each other


            //myInt = int.MaxValue;
            //Console.WriteLine(myInt);
            //myLong = myInt;
            //myLong += 1;
            //Console.WriteLine(myLong);
            //myInt = (int)myLong;
            //Console.WriteLine(myInt); //when integer types exceed their limits, their values wrap

            //myFloat = 1 / 7;
            //Console.WriteLine(myFloat); // what value will this line write to the console?

            //numOfDaysInWeek = 8; //constants cannot be changed

            //int int1 = 2;
            //int int2 = 4;

            //int1 = int2;
            //int2 = int1; //this technique does not properly switch the values of the ints

            //int temp = int1;
            //int1 = int2;
            //int2 = temp; //this technique successfully switches the values of the two ints by using a temporary third int variable

            //Console.WriteLine("int1: " + int1 + ", int2: " + int2);

            //myBool = true;
            //if(myBool == true) //the '==' operator is a boolean operator that returns true if its two operands are equal
            //{
            //    Console.WriteLine("myBool is true!"); //code inside this block will only be run if the condition above evaluates to true
            //}

            //if(!myBool) //'!' is the negation operator; it returns the inverse value of its operand
            //{
            //    Console.WriteLine("myBool is false!")
            //}

            //if (myBool) // 'if(myBool == true)' and 'if(myBool)' are equivalent expressions
            //{
            //    Console.WriteLine("myBool is true!");
            //}
            //else
            //{
            //    Console.WriteLine("myBool is false!"); //code in an else block only runs if the if condition above it evaluates to false 
            //}

            //string message = myBool ? "myBool is true!" : "myBool is false!"; //ternary operators simplify basic if statements
            //Console.WriteLine(message);

            //bool anotherBool = true;
            //if(myBool && anotherBool) //'&&' returns true if both its operands are true
            //{
            //    Console.WriteLine("both myBool and anotherBool are true!");
            //}
            //else if(myBool || anotherBool) //'||' returns true if one or both its operands are true
            //{
            //    Console.WriteLine("either myBool or anotherBool is true!"); //code in an else if block only runs if the if condition above it evaluates to false, AND the else if condition evaluates to true 
            //}
            //else
            //{
            //    Console.WriteLine("neither myBool nor anotherBool are true");
            //}

            //Console.WriteLine(currentDirection); //default value for enum types are their first value

            //currentDirection = Direction.West;
            //Console.WriteLine(currentDirection);

            //currentDirection = (Direction)1; //ints can be cast into enums
            //Console.WriteLine(currentDirection);
            //Console.WriteLine((int)currentDirection); //enums can be cast into ints

            //if (currentDirection == Direction.North)
            //    Console.WriteLine("polar bears");
            //else if (currentDirection == Direction.South)
            //    Console.WriteLine("penguins");
            //else if (currentDirection == Direction.East)
            //    Console.WriteLine("sunrise");
            //else
            //    Console.WriteLine("sunset");

            //switch (currentDirection)
            //{
            //    case Direction.North:
            //        Console.WriteLine("polar bears");
            //        break;
            //    case Direction.South:
            //        Console.WriteLine("penguins");
            //        break;
            //    case Direction.East:
            //        Console.WriteLine("sunrise");
            //        break;
            //    case Direction.West:
            //        Console.WriteLine("sunset");
            //        break;
            //    default:
            //        Console.WriteLine("uh oh, this code should not be reachable!");
            //        break;
            //}

            //Console.WriteLine("Please enter y for 'yes', n for 'no', or any other character for 'maybe'");
            //myChar = char.Parse(Console.ReadLine());
            //switch (myChar)
            //{
            //    case 'y':
            //        Console.WriteLine("You selected Yes!");
            //        break;
            //    case 'n':
            //        Console.WriteLine("You selected No!");
            //        break;
            //    default:
            //        Console.WriteLine("You selected Maybe!");
            //        break;
            //}

            //words = new string[] { "shoe", "elephant", "doubt" }; //using object initializer syntax to populate an array as it is instantiated

            //Console.WriteLine(words[0]);
            //Console.WriteLine(words[1]);
            //Console.WriteLine(words[2]);

            //for(int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(words[i]);
            //}

            //Console.WriteLine("What size of array would you like to make?");
            //int arraySize = int.Parse(Console.ReadLine()); //strings need to be parsed to be used or stored as ints
            //words = new string[arraySize];

            //for(int i = 0; i < words.Length; i++ )
            //{
            //    Console.WriteLine("Please enter a word");
            //    words[i] = Console.ReadLine();
            //}

            //Console.WriteLine("You entered the following words:");

            //foreach(string str in words)
            //{
            //    Console.Write(str + ", ");
            //}

            int[] arrayOfInts;
            int sizeOfArray = 0;
            bool validInput = false;
            Console.WriteLine("What size of array would you like to make?");
            while (!validInput) //using a while loop and a TryParse call as follows is a safe way to get an integer from user keyboard input
            {
                Console.WriteLine("Please enter an array size");
                validInput = int.TryParse(Console.ReadLine(), out sizeOfArray);
            }
            arrayOfInts = new int[sizeOfArray];

            for (int i = 0; i < arrayOfInts.Length; i++)
            {
                int intToAdd = 0;
                bool successfulParse = false;
                while (!successfulParse)
                {
                    Console.WriteLine("Please enter an integer");
                    successfulParse = int.TryParse(Console.ReadLine(), out intToAdd);
                }
                arrayOfInts[i] = intToAdd;
            }

            //int sumOfArrayIntegers = 0;
            //for (int i = 0; i < arrayOfInts.Length; i++)
            //{
            //    sumOfArrayIntegers += arrayOfInts[i];
            //}

            //Console.WriteLine("The sum of the integers in the array you filled is: " + sumOfArrayIntegers);

            //float averageOfArrayIntegers = sumOfArrayIntegers / arrayOfInts.Length; //this is an int division, so it will be rounded down to an int before being cast into a float and stored in the variable 

            //float averageOfArrayIntegers = (float)sumOfArrayIntegers / (float)arrayOfInts.Length; //casting one or both of the operands to floats will cause the division to be a float division, and prevent int rounding 

            //Console.WriteLine("The average of the integers in the array you filled is: " + averageOfArrayIntegers);






        }
    }
}
