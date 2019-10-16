using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals1
{
    class Animal
    {
        public string species;
        public string name;
        public float weight;
        public int age;

        public void Display()
        {
            Console.WriteLine(name + " is a " + age + "-year-old " + species + " weighing " + weight + "kg.");
        }
    }

}
