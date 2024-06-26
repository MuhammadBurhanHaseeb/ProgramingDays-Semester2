using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeslaCoffeeShop.BL
{
    class MenuItem
    {
       public  MenuItem (string itemName ,string itemType,int itemPrice)
       {
            this.itemName = itemName;
            this.itemType = itemType;
            this.itemPrice = itemPrice;
       }
        public string itemName;
        public string itemType;
        public int itemPrice;
    }
}
