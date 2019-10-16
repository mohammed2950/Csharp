using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            people.Add(new Student("Wendy", 20));
            people.Add(new Student("Eric", 26));
            people.Add(new Teacher("Mary", 34));
            people.Add(new Teacher("Matthew", 30));
            people.Add(new Person("Regina", 9));

            foreach (Person p in people)
                p.Display();
        }
    }
}
