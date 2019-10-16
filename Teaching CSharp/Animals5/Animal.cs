using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals5
{
    public enum AnimalFamily { Fish, Bird, Reptile, Mammal, Insect };

    class Animal
    {

        //--Properties--//
        public string Species { get; private set; }
        public AnimalFamily Family { get; private set; }
        public bool IsPredator { get; private set; }
        public string Name { get; private set; } 
        public string FullName { get { return Name + " the " + Species; } } //readonly property, because it has no set block

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
        public Animal(string _species, AnimalFamily _family, bool _isPredator, string _name, float _weight, int _age)
        {
            Species = _species;
            Family = _family;
            IsPredator = _isPredator;
            Name = _name;
            Weight = _weight;
            Age = _age;

            Console.WriteLine("A new animal, " + FullName + ", has been created.");
            AnimalManager.masterList.Add(this);
        }
        //--End of Constructors--//


        //--Functions--//
        public void Display()
        {
            string areOrAreNot;
            if (IsPredator)
                areOrAreNot = " are ";
            else
                areOrAreNot = " are not ";

            Console.WriteLine(Name + " is a " + Age + "-year-old " + Species + " weighing " + Weight + "kg.\n" + Name + " is a member of the " + Family + " family, and they" + areOrAreNot + "a predator");
        }

        public void MakeNoise()
        {
            switch (Family)
            {
                case AnimalFamily.Fish:
                    Console.WriteLine("Blurp?");
                    break;
                case AnimalFamily.Bird:
                    Console.WriteLine("Squawk!");
                    break;
                case AnimalFamily.Reptile:
                    Console.WriteLine("Hiss!");
                    break;
                case AnimalFamily.Mammal:
                    Console.WriteLine("Grunt!");
                    break;
                case AnimalFamily.Insect:
                    Console.WriteLine("Buzz!");
                    break;
                default:
                    break;
            }
        }

        //--End of Functions--//







    }

}
