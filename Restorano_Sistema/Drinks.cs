using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restorano_Sistema
{
    public class Drinks
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public Drinks(string name, int price)
        {
            Name = name;
            Price = price;
        }
    }
}
