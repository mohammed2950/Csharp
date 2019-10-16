using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals6
{
    public enum AnimalFamily { Fish, Bird, Reptile, Mammal, Insect };
    class Animal
    {
        //--Statics--//
        static float GrowthRate = .1f;
        //--End of Statics--//


        //-------------------------------------------------------------//


        //--Properties--//
        public string Species { get; private set; }
        public AnimalFamily Family { get; private set; }
        public bool IsPredator { get; private set; }
        public string Name { get; private set; }
        public string FullName { get { return Name + " the " + Species; } }

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

        public void Chase(Animal otherAnimal)
        {
            Console.WriteLine(FullName + " is chasing " + otherAnimal.FullName);
            MakeNoise();
        }
        public void RunAway(Animal otherAnimal)
        {
            Console.WriteLine(FullName + " is runnig from " + otherAnimal.FullName);
            MakeNoise();
        }

        public void GetOlder(int numberOfYears)
        {
            Age += numberOfYears;
            Grow(numberOfYears * GrowthRate * Weight);
            Console.WriteLine(FullName + " is now " + Age + " years old!");
        }

        public void Grow(float weightChange)
        {
            Weight += weightChange;
            Console.WriteLine(FullName + " has gained " + weightChange + "kg for a total weight of " + Weight + "kg");
        }

        public void EatAnimal(Animal otherAnimal)
        {
            Console.WriteLine(FullName + " has eaten " + otherAnimal.FullName + "!");
            Grow(otherAnimal.Weight);
            otherAnimal.Die();
        }

        public void Die()
        {
            Console.WriteLine(FullName + " has died. How sad.");
            AnimalManager.masterList.Remove(this);
        }
        //--End of Functions--//







    }
}
