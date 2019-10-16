using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals3
{
    class Animal
    {
        //--Variables--//
        private string species;
        private string name;
        private float weight;
        private int age;
        //--End of Variables--//


        //--Getters and Setters--//
        public string GetSpecies()
        {
            return species;
        }
        private void SetSpecies(string value)
        {
            species = value;
        }
        public string GetName()
        {
            return name;
        }
        private void SetName(string value)
        {
            name = value;
        }
        public float GetWeight()
        {
            return weight;
        }
        private void SetWeight(float value)
        {
            if (value <= 0)
                weight = 0;
            else
                weight = value;
        }
        public int GetAge()
        {
            return age;
        }
        private void SetAge(int value)
        {
            if (value <= 0)
                age = 0;
            else
                age = value;
        }

        //--End of Getters & Setters--//


        //--Constructors & Destructors--//
        public Animal(string _species, string _name, float _weight, int _age)
        {
            SetSpecies(_species);
            SetName(_name);
            SetWeight(_weight);
            SetAge(_age);

            //Species = _species;
            //Name = _name;
            //Weight = _weight;
            //Age = _age;
        }

         ~Animal()
        {
            Console.WriteLine("We don't really know when this will be called, because the automatic garbage collector is unpredictable");
        }
        
        //--End of Constructors & Destructors--//


        //--Functions--//
        public void Display()
        {
            Console.WriteLine(name + " is a " + age + "-year-old " + species + " weighing " + weight + "kg.");
        }

        //--End of Functions--//


        //--Properties--//
        //public string Species { get { return species; } private set { species = value; } }
        //public string Name { get { return name; } private set { name = value; } }
        //public float Weight
        //{
        //    get
        //    {
        //        return weight;
        //    }
        //    private set
        //    {
        //        if (value <= 0)
        //            weight = 0f;
        //        else
        //            weight = value;
        //    }
        //}
        //public int Age
        //{
        //    get { return age; }
        //    private set { if (value <= 0) { age = 0; } else { age = value; } }
        //}

        //--End of Properties--//




    }

}
