using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People2
{
    class Student : Person
    {
        private static int nextID = 0;

        public int StudentID { get; private set; }

        public Student(string name, int age) : base(name, age)
        {
            StudentID = nextID;
            nextID++;
        }

        public void Study()
        {
            Console.WriteLine("Student studying");
        }

        public override void Display()
        {
            Console.WriteLine("Student named " + Name + " with student ID: " + StudentID);
        }
    }
}
