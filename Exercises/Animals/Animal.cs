using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Animal
    {
        public string name;
       public int age;
        public string species;

        public Animal()
        {

        }
        public Animal(string _name,int age, string _species)
        {
            name = _name;
            this.age = age;
            species = _species;
        }

        public void Display()
        {
            Console.WriteLine(name + " is of spicies  " + species + " and is of " + age + "age");
        }
    }
}
