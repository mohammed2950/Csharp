using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Animal> animals = new List<Animal>();
            animals.Add(new Animal("wnddy", 7, "cat"));
            animals.Add(new Animal("sandy", 5, "dog"));



            Animal a = new Animal("nancy" , 10,"frog");
            Animal b = new Animal("john",6,"bear") { };
           
          
            a.Display();
           b.Display();

            Console.ReadKey();
        }


        static Animal CreateNewAnimal(string name, int age, string species)
        {
            Animal toReturn = new Animal();
            toReturn.name =  name;
            toReturn.age =  age;
            toReturn.species =  species;

            return toReturn;
        }
    }

}
