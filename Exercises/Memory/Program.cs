using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    class Program
    {
        static string[] testArray;
        static void Main(string[] args)
        {
            //IntTest();
            //ArrayTest();
            //StringTest();
            //NullableIntTest();
            //NullArrayTest();
            //NullCoalescingTest();
        }

        static void IntTest()
        {
            int a = 2;
            int b = a;
            a += 3;
            Console.WriteLine("b = " + b);
        }

        static void ArrayTest()
        {
            int[] a = new int[] { 1, 2, 3 };
            int[] b = a;
            a[0] = 2;
            Console.WriteLine("b[0] = " + b[0]);
        }

        static void StringTest()
        {

            string a = "moo";
            string b = a;
            a = "shoe";
            Console.WriteLine("b = " + b);
        }

        static void NullableIntTest()
        {
            int? a = 5;
            Nullable<int> b = null; // type? is the same as Nullable<type>

            Console.WriteLine(a.HasValue);
            Console.WriteLine(b.HasValue);

            a = b;
            Console.WriteLine(a == null);

            a = 5 + b;
            Console.WriteLine(a);


            int c = (int)b; // will throw an error
        }

        static void NullArrayTest()
        {
            //Console.WriteLine(testArray == null);
            testArray = new string[3];
            //Console.WriteLine(testArray == null);
            foreach (string s in testArray)
                Console.WriteLine(s == null);
        }

        static void NullCoalescingTest()
        {
            string mystring = "chimney";
            //mystring = null;
            string message = mystring ?? "myString is null";
            Console.WriteLine(message);
        }
    }
}
 