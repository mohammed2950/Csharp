using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Student
    {
        public string name;
        

        public Student(string _name)
        {
            name = _name;
        }

        public void RegisterAsTeacherObserver(Teacher t)
        {
            t.studentsGradedHandler += ReceiveGradesNotification;
        }

        public void ReceiveGradesNotification(Teacher notifier)
        {
            Console.WriteLine("Student " + name + " has been notified to check isco because their teacher, " + notifier.name + " has just submitted their grades!");
        }
    }
}
