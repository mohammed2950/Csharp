using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals6
{
    static class AnimalManager
    {
        public static List<Animal> masterList = new List<Animal>();

        public static int livingAnimalCount { get { return masterList.Count; } }

        public static void DisplayAnimalCount()
        {
            Console.WriteLine("There are currently " + livingAnimalCount + " animals alive.");
        }

        public static void DisplayAllAnimals()
        {
            Console.WriteLine("These are all the animals that are currently alive:");
            foreach (Animal a in masterList)
            {
                a.Display();
            }
        }

        public static void TimePasses(int numOfYears)
        {
            Console.WriteLine("Time has passed. Years elapsed: " + numOfYears);
            foreach (Animal a in masterList)
                a.GetOlder(numOfYears);
        }

        public static void Encounter(Animal animal1, Animal animal2)
        {
            if (animal1.IsPredator && !animal2.IsPredator)
            {
                animal1.Chase(animal2);
                animal2.RunAway(animal1);
                animal1.EatAnimal(animal2);
            }
            else if (animal2.IsPredator && !animal1.IsPredator)
            {
                animal2.Chase(animal1);
                animal1.RunAway(animal2);
                animal2.EatAnimal(animal1);
            }
            else if (animal1.IsPredator && animal2.IsPredator)
            {
                Console.WriteLine(animal1.FullName + " and " + animal2.FullName + " crossed paths and went their separate ways");
            }
            else
            {
                animal1.RunAway(animal2);
                animal2.RunAway(animal1);
            }
        }

    }
}
