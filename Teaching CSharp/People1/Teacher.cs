using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People1
{
    class Teacher : Person
    {
        

        public Teacher(string name, int age) : base(name, age)
        {
         
        }

        public void GiveLecture()
        {
            Console.WriteLine("Teacher giving lecture");
        }

        public void Display()
        {
            Console.WriteLine("Teacher named " + Name);
        }
    }
}
