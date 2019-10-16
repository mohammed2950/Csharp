using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals1
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal();
            //a1.Display();

            //a1.species = "alligator";
            //a1.name = "Eleanor";
            //a1.age = 42;
            //a1.weight = 211.22f;
            //a1.Display();

            Animal a2 = a1;
            a2.Display();
            a1.name = "Morgan";
            a1.Display();
            a2.Display();

            //a2 = new Animal();
            //a2.species = "grasshopper";
            //a2.name = "Elijah";
            //a2.age = 1;
            //a2.weight = .001f;

            //a1.Display();
            //a2.Display();

            //Animal[] animals = new Animal[] { a1, a2, a2, new Animal() };
            //foreach (Animal a in animals)
            //    a.Display();

            Animal a3 = MakeNewAnimal("octopus", "Oliver", 24, 34.7f);

            //Animal[] anotherAnimalArray = new Animal[2];
            //anotherAnimalArray[0] = a3;
            //anotherAnimalArray[1] = MakeNewAnimal("bat", "Susan", 2, 1.1f);
            //foreach (Animal a in anotherAnimalArray)
            //    a.Display();
        }

        static Animal MakeNewAnimal(string _species, string _name, int _age, float _weight)
        {
            Animal toReturn = new Animal();

            toReturn.species = _species;
            toReturn.name = _name;
            toReturn.age = _age;
            toReturn.weight = _weight;

            return toReturn;
        }
    }
}
