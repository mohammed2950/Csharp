using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            School.InitializeSchool();

            Console.WriteLine("The HTML teacher, Helena, and the networks teacher, Jason, are busy grading their students");
            Console.ReadKey();

            Console.WriteLine("Helena has finished grading her students!");
            School.Teachers[0].FinishGradingStudents();
            Console.ReadKey();

            Console.WriteLine("Jason is still grading his students");
            Console.ReadKey();

            Console.WriteLine("Jason has finished grading his students!");
            School.Teachers[1].FinishGradingStudents();
           
        }
    }
}
