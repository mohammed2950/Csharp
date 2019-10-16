using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals5
{
    static class AnimalManager
    {
        public static List<Animal> masterList = new List<Animal>();

        public static int livingAnimalCount { get { return masterList.Count; } }

        public static void DisplayAnimalCount()
        {
            Console.WriteLine("There are currently " + livingAnimalCount + " animals alive.");
        }

       
    }
}
