using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class ListDatabase : IPersonDatabase
    {
        List<Person> database = new List<Person>();

        public void Add(Person toAdd)
        {
            database.Add(toAdd);
        }

        public void Remove(Person toRemove)
        {
            if(database.Remove(toRemove))
            {
                return;
            }
            else
            {
                Console.WriteLine("Error: person not found");
            }
        }

        public void Remove(string nameToRemove)
        {
            foreach(Person p in database)
            {
                if(p.Name == nameToRemove)
                {
                    database.Remove(p);
                }
            }
            Console.WriteLine("No person by the name of " + nameToRemove + " was found");
        }

        public Person Search(string nameToSearch)
        {
            foreach (Person p in database)
            {
                if(p.Name == nameToSearch)
                {
                    return p;
                }
            }
            return null;
        }

        public bool Contains(Person toCheck)
        {
            return database.Contains(toCheck);
        }

        public bool Contains(string nameToCheck)
        {
            foreach(Person p in database)
            {
                if(p.Name == nameToCheck)
                {
                    return true;
                }
            }
            return false;
        }

        
    }
}
