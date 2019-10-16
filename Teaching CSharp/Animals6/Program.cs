using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals6
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal("gazelle", AnimalFamily.Mammal, false, "Salvador", 126f, 5);
            Animal a2 = new Animal("crocodile", AnimalFamily.Reptile, true, "Gertrude", 147.1f, 22);
            Animal a3 = new Animal("bumblebee", AnimalFamily.Insect, false, "Hildegard", .0004f, 0);
            Animal a4 = new Animal("squirrel", AnimalFamily.Mammal, false, "Leslie", .46f, 2);
            Animal a5 = new Animal("eagle", AnimalFamily.Bird, true, "Estoban", 14.89f, 6);

            AnimalManager.Encounter(a1, a2);
            AnimalManager.DisplayAnimalCount();

            AnimalManager.TimePasses(2);

            AnimalManager.Encounter(a2, a5);
            AnimalManager.Encounter(a3, a4);
            AnimalManager.Encounter(a5, a4);

            AnimalManager.DisplayAllAnimals();
        }
    }
}
