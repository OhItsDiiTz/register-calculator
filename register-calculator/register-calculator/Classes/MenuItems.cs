using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace register_calculator.Classes
{
    public class MenuItems
    {
        public string ShortName;
        public string Name;
        public int Price;
        public MenuItems(string shortname, string name, int price)
        {
            ShortName = shortname;
            Name = name;
            Price = price;
        }
    }
}
