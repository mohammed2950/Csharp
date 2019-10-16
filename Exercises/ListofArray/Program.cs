using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static List<string> names = new List<string>();

        static void Main(string[] args)
        {

            List<string> words = new List<string>() { "hello", "hi", "bye" };
            
            Console.WriteLine(names.Count);

            names.Add("Heloise");
            names.Add("Stephane");
            names.Add("Margo");
            names.Add("Colby");

            Console.WriteLine("Number of strings in the list: " + names.Count);

            Console.WriteLine("These are all the strings currently in the list:");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            names.Remove("Heloise");

            Console.WriteLine(names[0]);

            names.RemoveAt(1);

            if (names.Contains("Margo"))
                Console.WriteLine("The list contains Margo");
            else
                Console.WriteLine("The list does not contain Margo");

            string[] namesArray = names.ToArray();
            string[] wordsArray = words.ToArray();

            namesArray[1] = null;
            names.RemoveAt(1);

            Console.WriteLine("Number of strings in the list: " + words.Count);

            Console.WriteLine("Number of strings in the list: " + names.Count);
            Console.WriteLine("Size of array: " + namesArray.Length);
            Console.ReadLine();
        }

    }
}
