using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeslaCoffeeShop.BL
{
    class MenuItemBL
    {
       public  MenuItemBL (string itemName ,string itemType,int itemPrice)
       {
            this.itemName = itemName;
            this.itemType = itemType;
            this.itemPrice = itemPrice;
       }
       private  string itemName;
       private  string itemType;
        private  int itemPrice;

        public string  getItemName()
        {
            return itemName;
        }
        public string getItemType()
        {
            return itemType;
        }
        public int  getItemPrice()
        {
            return itemPrice;
        }
        public void  setItemName(string itemName)
        {
            this.itemName = itemName; 
        }
        public void setItemType(string itemType)
        {
            this.itemType = itemType;
        }
        public void  setItemPrice(int itemPrice)
        {
            this.itemPrice = itemPrice ; 
        }
    }
}
