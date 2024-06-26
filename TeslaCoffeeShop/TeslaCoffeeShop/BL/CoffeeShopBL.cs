using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeslaCoffeeShop.BL
{
    class CoffeeShopBL
    {
        public CoffeeShopBL(string name)
        {
            this.name = name;
        }
       private  string name;
        public void setName(string name)
        {
            this.name = name;

        }
        public string getName()
        {
            return name;
        }

    }
}
