using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeslaCoffeeShop.BL;
using TeslaCoffeeShop.DL;
namespace TeslaCoffeeShop.UI
{
    class MenuItemUI
    {
        public static MenuItemBL addMenu()
        {
            string name, type;
            int price;
            Console.WriteLine("enter the name of the product :");
            name = Console.ReadLine();
            Console.WriteLine("enter the type of the product :");
            type = Console.ReadLine();
            Console.WriteLine("enter the price of the product :");
            price = int.Parse(Console.ReadLine());
            MenuItemBL add = new MenuItemBL(name, type, price);
            return add;

        }
        public static void viewFoodsMenu()
        {
            Console.WriteLine("name \t type \t price");
            foreach (MenuItemBL s in MenuItemDL.menuList)
            {
                if (s.getItemType() == "foods")
                {
                    Console.WriteLine(s.getItemName() + "\t" + s.getItemType() + "\t" + s.getItemPrice());
                }
            }
            Console.ReadKey();
        }
        public static void viewDrinksMenu()
        {
            Console.WriteLine("name \t type \t price");
            foreach (MenuItemBL s in MenuItemDL.menuList)
            {
                if (s.getItemType() == "drinks")
                {
                    Console.WriteLine(s.getItemName() + "\t" + s.getItemType() + "\t" + s.getItemPrice());
                }
            }
            Console.ReadKey();
        }
    }
}
