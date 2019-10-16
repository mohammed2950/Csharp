using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    

    class Teacher
    {
        public delegate void TeacherDelegate(Teacher teacher);


        public string name;
        public List<Student> Students = new List<Student>();
        public TeacherDelegate studentsGradedHandler;

        public Teacher(string _name)
        {
            name = _name;
        }

        public void FinishGradingStudents()
        {
            Console.WriteLine("Teacher " + name + " has submitted their students' grades!");
            studentsGradedHandler.Invoke(this);
        }
    }
}
