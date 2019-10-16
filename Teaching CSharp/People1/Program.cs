using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Myka", 28);
            //s1.Display();
            Person p1 = s1;
            //p1.Display();

            Person p2 = new Teacher("Loic", 25);
            //p2.Display();
            //Teacher t1 = (Teacher)p2;
            Student s2 = null;
            if (p2 is Student)
            {
                s2 = (Student)p2;
                s2.Display();
            }
            else
            {
                Console.WriteLine("p2 is not a student");
            }
            
        }
    }
}
