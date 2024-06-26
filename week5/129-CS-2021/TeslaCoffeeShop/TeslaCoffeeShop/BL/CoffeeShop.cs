using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeslaCoffeeShop.BL
{
    class CoffeeShop
    {
        public CoffeeShop(string name)
        {
            this.name = name;
        }
        public string name;
        public static List<MenuItem> menuList = new List<MenuItem>();
        public static List<string> orders = new List<string>();
    }
}
