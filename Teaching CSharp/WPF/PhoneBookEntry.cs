using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF
{
    class PhoneBookEntry
    {
        public string LastName { get; private set; }
        public string FirstName { get; private set; }
        public string PhoneNumber { get; private set; }

        public PhoneBookEntry(string lastName, string firstName, string phoneNumber)
        {
            LastName = lastName;
            FirstName = firstName;
            PhoneNumber = phoneNumber;
        }
    }
}
