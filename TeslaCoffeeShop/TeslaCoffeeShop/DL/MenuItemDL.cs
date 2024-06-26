using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeslaCoffeeShop.BL;
using System.IO;

namespace TeslaCoffeeShop.DL
{
    class MenuItemDL
    {
        public static List<MenuItemBL> menuList = new List<MenuItemBL>();

        public static int cheapestItem()
        {
            int price = menuList[0].getItemPrice();
            for (int x = 1; x < menuList.Count; x++)
            {
                if (price > menuList[x].getItemPrice())
                {
                    price = menuList[x].getItemPrice();
                }
            }
            return price;
            // Console.WriteLine("the cheapest price of the product in the menu list is : " + price);
            // Console.ReadKey();
        }

        public static void addIntoList(MenuItemBL s)
        {

            menuList.Add(s);
        }
        public static void addIntoFile(MenuItemBL s)
        {
            string path = "Menu.txt";
            StreamWriter f = new StreamWriter(path,true);
            f.WriteLine(s.getItemName() + ","+s.getItemType() + ","+s.getItemPrice());
            f.Flush();
            f.Close();
        }
        public static void loadMenu()
        {
            string record;
            string path = "Menu.txt";
            StreamReader f = new StreamReader(path);
            if (File.Exists(path))
            {
                while((record = f.ReadLine())!=null )
                {
                    string[] load = record.Split(',');
                    string name = load[0];
                    string type = load[1];
                    int price =int.Parse( load[2]);
                    MenuItemBL s = new MenuItemBL(name , type , price);
                    MenuItemDL.menuList.Add(s);
                }
            }
            else
            {
                Console.WriteLine("file not exists>>>");
                Console.ReadKey();
            }
            f.Close();
        }
    }
}
