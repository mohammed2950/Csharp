using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals3
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal someAnimal = new Animal("praying mantis", "Esmerelda", .00024f, -1);
            someAnimal.Display();

            //Console.WriteLine(someAnimal.name); //name is a private field
            //Console.WriteLine(someAnimal.GetName()); //GetName(), however, is a public function
            //someAnimal.SetName("Anne"); //SetName() is a private function

            //Console.WriteLine(someAnimal.Name); //This calls the public get block of the Name property, which returns a copy of the private string name


            //Animal a1 = new Animal("goose", "Maria", 15.1f, 3); 
            //Animal a2 = a1;

            Console.ReadKey();
        }
    }
}
