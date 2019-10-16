using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Person : ITimePassable
    {
        public int Age { get; private set; }

        public void PassTime(int years)
        {
            Age += years;
        }
    }
}
