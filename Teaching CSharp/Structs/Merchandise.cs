using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    struct Merchandise
    {
        public string item;
        public float price;
        
       

        public Merchandise(string _item, float _price)
        {
            item = _item;
            price = _price;
        }

        public void Display()
        {
            Console.WriteLine("Item: " + item + ", Price: " + price);
        }
    }
}
