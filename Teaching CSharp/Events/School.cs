using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    static class School
    {
        public static Director director = new Director("Bruno");

        public static List<Teacher> Teachers = new List<Teacher>();

        public static void InitializeSchool()
        {
            Teacher htmlTeacher = new Teacher("Helena");
            htmlTeacher.Students.Add(new Student("Sam"));
            htmlTeacher.Students.Add(new Student("Betsy"));
            htmlTeacher.Students.Add(new Student("Ryan"));
            Teachers.Add(htmlTeacher);

            Teacher networksTeacher = new Teacher("Jason");
            networksTeacher.Students.Add(new Student("Barnie"));
            networksTeacher.Students.Add(new Student("Heloise"));
            networksTeacher.Students.Add(new Student("Lilian"));
            Teachers.Add(networksTeacher);

            RegisterTeacherObservers();
        }

        static void RegisterTeacherObservers()
        {
            foreach(Teacher t in Teachers)
            {
                director.RegisterAsTeacherObserver(t);

                foreach (Student s in t.Students)
                {
                    s.RegisterAsTeacherObserver(t);
                }
            }
        }

    }






}
