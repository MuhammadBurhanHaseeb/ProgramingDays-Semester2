using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeslaCoffeeShop.BL;
using TeslaCoffeeShop.DL;
namespace TeslaCoffeeShop.UI
{
    class CoffeeShopUI
    {
        public static string  addOrder()
        {
            string name;
            Console.WriteLine("enter the name of the product ");
            name = Console.ReadLine();
            foreach (MenuItemBL s in MenuItemDL.menuList)
            {
                if (name == s.getItemName())
                {
                    return name;
                    //CoffeeShopDL.addIntoList(name);
                   //CoffeeShopDL.addIntoFile(name);
                  //  CoffeeShopBL.orders.Add(name);
                }
            }
            return null;
        }
        public  static void viewOrderList()
        {
            for (int x = 0; x < CoffeeShopDL.orders.Count; x++)
            {
                Console.WriteLine(CoffeeShopDL.orders[x]);
            }
            Console.ReadKey();
        }
        public static void fulfillOrder()
        {
            for (int x = 0; x < CoffeeShopDL.orders.Count; x++)
            {
                Console.WriteLine("the order of " + CoffeeShopDL.orders[x] + " is ready");
            }
            Console.WriteLine("the all oredrs are delivered >>");
            Console.ReadKey();
            CoffeeShopDL.orders.Clear();
        }

    }
}
