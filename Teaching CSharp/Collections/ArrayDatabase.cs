using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class ArrayDatabase : IPersonDatabase
    {
       public Person[] database;

        public ArrayDatabase(int size)
        {
            database = new Person[size];
        }

        public void Add(Person toAdd)
        {
            for (int i = 0; i < database.Length; i++)
            {
                if(database[i] == null)
                {
                    database[i] = toAdd;
                    return;
                }
            }
            Console.WriteLine("Error: Database is full");
        }

        public void Remove(Person toRemove)
        {
            for (int i = 0; i < database.Length; i++)
            {
                if(database[i] == toRemove)
                {
                    database[i] = null;
                    return;
                }
            }
            Console.WriteLine("Error: person not found");
        }

        public void Remove(string nameToRemove)
        {
            for (int i = 0; i < database.Length; i++)
            {
                if(database[i].Name == nameToRemove)
                {
                    database[i] = null;
                    return;
                }
            }
            Console.WriteLine("No person by the name of " + nameToRemove + " was found");
        }

        public Person Search(string nameToSearch)
        {
            for(int i = 0; i < database.Length; i++)
            {
                if(database[i].Name == nameToSearch)
                {
                    return database[i];
                }
            }
            Console.WriteLine("No person by the name of " + nameToSearch + " was found. Returning null");
            return null;
        }

        public bool Contains(Person toCheck)
        {
            for (int i = 0; i < database.Length; i++)
            {
                if(database[i] == toCheck)
                {
                    return true;
                }
            }
            return false;
        }

        public bool Contains(string nameToCheck)
        {
            for (int i = 0; i < database.Length; i++)
            {
                if(database[i].Name == nameToCheck)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
