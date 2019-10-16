using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Director
    {
        public string name;

        public Director(string _name)
        {
            name = _name;
        }

        public void RegisterAsTeacherObserver(Teacher t)
        {
            t.studentsGradedHandler += PayTeacher;
        }

        public void PayTeacher(Teacher toPay)
        {
            Console.WriteLine("Director " + name + " has paid teacher " + toPay.name + " because " + toPay.name + " has finally finished grading their students!");
        }
    }
}
