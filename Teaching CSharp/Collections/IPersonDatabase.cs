using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    interface IPersonDatabase
    {
        void Add(Person toAdd);

        void Remove(Person toRemove);

        void Remove(string nameToRemove);

        Person Search(string nameToSearch);

        bool Contains(Person toCheck);

        bool Contains(string nameToCheck);

    }
}
