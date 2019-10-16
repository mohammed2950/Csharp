using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class BankAccount : ITimePassable
    {
        static float interestRate = .1f;

        public float balance { get; private set; }

        public void PassTime(int years)
        {
            balance += (balance * interestRate * years);
        }
    }
}
