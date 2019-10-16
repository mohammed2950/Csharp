using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals4
{
    class Animal
    {
        //--Static Variables and Functions--//
        public static int livingAnimalCount = 0;

        public static void DisplayAnimalCount()
        {
            Console.WriteLine("There are currently " + livingAnimalCount + " animals alive.");
        }
        //--End of Static Variables and Functions--//




//---------------------------------------------------------------------------------------------------------//




        //--Properties--//
        public string Species { get; private set; } // Auto-implemented property

        public string Name { get; private set; } // Auto-implemented property

        private float weight;
        public float Weight
        {
            get { return weight; }
            private set { if (value <= 0) { weight = 0; } else { weight = value; } }
        }

        private int age;
        public int Age
        {
            get { return age; }
            private set { if (value <= 0) { age = 0; } else { age = value; } }
        }
        //--End of Properties--//


        //--Constructors--//
        public Animal(string _species, string _name, float _weight, int _age)
        {
            Species = _species;
            Name = _name;
            Weight = _weight;
            Age = _age;

            Console.WriteLine("A new animal, " + Name + " the " + Species + ", has been created.");
            livingAnimalCount++;
        }
        //--End of Constructors--//


        //--Functions--//
        public void Display()
        {
            Console.WriteLine(Name + " is a " + Age + "-year-old " + Species + " weighing " + Weight + "kg.");
        }
        //--End of Functions--//







    }

}
