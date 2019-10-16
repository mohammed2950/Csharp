using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals4
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Animal("beaver", "Erickson", 21.02f, 9);
            Animal animal2 = new Animal("wildebeast", "Samus", 182.2f, 4);
            Animal animal3 = new Animal("baluga", "Guinivere", 1409.3f, 17);

            //Animal.Display();//Calling non-static functions or accessing non-static fields requires an object reference! 
            //The above line won't compile, because how does it know which animal's info should be displayed?

            //animal1.Display();//This is legal, because animal1 is an object reference,
            //so the Display() function of this particular instance(object) of class Animal is being called
            

            Animal.DisplayAnimalCount();// Static fields and functions, however are accessed directly through the class itself.
             //Only one copy of each static field or function exists, and it lives in the class itself
            //Console.WriteLine(Animal.livingAnimalCount);


            Console.ReadKey();
        }
    }
}
