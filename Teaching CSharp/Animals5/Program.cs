using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals5
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal("octopus", AnimalFamily.Fish, true, "Anders", 32.8f, 11);
            Animal a2 = new Animal("sparrow", AnimalFamily.Bird, false, "Marcy", .51f, 2);
            Animal a3 = new Animal("pig", AnimalFamily.Mammal, false, "Rudolph", 97.35f, 14);

            AnimalManager.DisplayAnimalCount();

            foreach(Animal a in AnimalManager.masterList)
            {
                a.Display();
                a.MakeNoise();
            }

        }
    }
}
