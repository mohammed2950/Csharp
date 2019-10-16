using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals2
{
    class Animal
    {
 
        //--Variables--//
        public string species;
        public string name;
        public float weight;
        public int age;
        //--End of Variables--//



        //--Constructors--//
        public Animal(string species, string name, float weight, int age)
        {
            this.species = species;
            this.name = name;
            this.weight = weight;
            this.age = age;
        }
        //public Animal()
        //{
        //    // this is not the default constructor!
        //    //Console.WriteLine("Our parameter-less constructor was called!");
        //}
        //--End of Constructors--//



        //--Functions--//
        public void Display()
        {
            Console.WriteLine(this.name + " is a " + age + "-year-old " + species + " weighing " + weight + "kg.");
        }
        //--End of Functions--//


    }

}
