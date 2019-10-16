using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF
{
    static class PhoneBook
    {
        public static List<PhoneBookEntry> Entries = new List<PhoneBookEntry>()
        {
            new PhoneBookEntry("Casey", "Roger", "467-6453" ),
            new PhoneBookEntry("Knox", "Kimberly", "834-3811" ),
            new PhoneBookEntry("Cohen", "Josef", "485-6988" ),
            new PhoneBookEntry("Gaines", "Beth", "154-6636" ),
            new PhoneBookEntry("Knox", "Phillis", "794-1958" ),
            new PhoneBookEntry("Gillespie", "Roger", "333-6487" ),
            new PhoneBookEntry("Cohen", "Winifred", "495-9987" ),
            new PhoneBookEntry("Dunn", "Crystal", "191-7875" )
        };

        public static List<PhoneBookEntry> SearchByLastName(string lastName)
        {
            List<PhoneBookEntry> toReturn = new List<PhoneBookEntry>();
            foreach (PhoneBookEntry entry in Entries)
                if (entry.LastName == lastName)
                    toReturn.Add(entry);
            return toReturn;
        }
    }
}
