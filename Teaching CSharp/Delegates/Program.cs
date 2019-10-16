using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    

    public delegate void TestDelegate(); // this is the definition of a new delegate type, not a declaration of a variable nor an instantiation of a delegate object

    public delegate float MathDelegate(float f1, float f2); // delegates of this type must point to functions that take two floats and return a float

    class Program
    {
        static MathDelegate addDelg = Add;
        static MathDelegate subtractDelg = Subtract;
        static MathDelegate multiplyDelg = Multiply;
        static MathDelegate divideDelg = Divide;
        static MathDelegate powerDelg = Power;


        static void Main(string[] args)
        {
            //TestDelegate td1 = new TestDelegate(Function1);
            //td1.Invoke();

            //TestDelegate td1 = Function1;
            //td1.Invoke();

            //TestDelegate td1 = Function1;
            //td1 += Function2;
            //td1 += Function3;
            ////td1.Invoke();
            //td1 -= Function2;
            //td1.Invoke();

            //Console.WriteLine(ExecuteMathFunction(2, 8, powerDelg));

            float result = UserMathOperation();
            Console.WriteLine("The result of your math operation is: " + result);
        }

        #region Test functions
        public static void Function1()
        {
            Console.WriteLine("Function1 called");
        }

        public static void Function2()
        {
            Console.WriteLine("Function2 called");
        }

        public static void Function3()
        {
            Console.WriteLine("Function3 called");
        }
        #endregion

        #region Math functions
        public static float Add(float left, float right)
        {
            return left + right;
        }

        public static float Subtract(float left, float right)
        {
            return left - right;
        }

        public static float Multiply(float left, float right)
        {
            return left * right;
        }

        public static float Divide (float left, float right)
        {
            return left / right;
        }

        public static float Power(float number, float exponent)
        {
            float result = number;
            for (int i = 1; i < (int)exponent; i++)
            {
                result *= number;
            }
            return result;
        }
        #endregion

        #region Math Delegate Control Functions

        public static float ExecuteMathFunction(float left, float right, MathDelegate toInvoke)
        {
            return toInvoke.Invoke(left, right);
        }

        public static float UserMathOperation()
        {
            Console.WriteLine("Please enter the left-hand number of the operation");
            float left = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the right-hand number of the operation");
            float right = float.Parse(Console.ReadLine());
            string operation = null;
            Console.WriteLine("Please specify which math operation you would like to execute");
            do
            {
                Console.WriteLine("Enter either add, subtract, multiply, divide, or power");
                operation = Console.ReadLine();
            }
            while (operation != "add" && operation != "subtract" && operation != "multiply" && operation != "divide" && operation != "power");

            MathDelegate toInvoke = ReturnMathDelgByString(operation);

            return ExecuteMathFunction(left, right, toInvoke);

        }

        public static MathDelegate ReturnMathDelgByString(string operationString)
        {
            switch (operationString)
            {
                case "add":
                    return addDelg;
                case "subtract":
                    return subtractDelg;
                case "multiply":
                    return multiplyDelg;
                case "divide":
                    return divideDelg;
                case "power":
                    return powerDelg;
                default:
                    return null;
            }
        }
        #endregion
    }
}
