using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People2
{
    class Person
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        

        public Person(String name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void Display()
        {
            Console.WriteLine("Name: " + Name + ", Age: " + Age);
        }

        
    }
}
