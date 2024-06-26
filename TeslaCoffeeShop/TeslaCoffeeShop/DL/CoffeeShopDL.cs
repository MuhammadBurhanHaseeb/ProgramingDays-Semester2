using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeslaCoffeeShop.BL;
using System.IO;
namespace TeslaCoffeeShop.DL
{
    class CoffeeShopDL
    {
        public static List<string> orders = new List<string>();

        public static void addIntoList(string name)
        {
            orders.Add(name);
        }
        public static void addIntoFile(string name )
        {
            string path = "order.txt";
            StreamWriter f = new StreamWriter(path ,true);
            f.WriteLine(name);
            f.Flush();
            f.Close();
        }
        public static int  payableAmount()
        {
            int price = 0;
            for (int x = 0; x < orders.Count; x++)
            {
                foreach (MenuItemBL s in MenuItemDL.menuList)
                {
                    if (orders[x] == s.getItemName())
                    {
                        price = price + s.getItemPrice();
                    }
                }
            }
            return price;
           // Console.WriteLine("the total amount of the orders is : " + price);
           // Console.ReadKey();
        }
        public static void loadOrder()
        {
            string record;
            string path = "order.txt";
            StreamReader f = new StreamReader(path);
            if (File.Exists(path))
            {
                while ((record = f.ReadLine()) != null)
                {
                    string[] load = record.Split(',');
                    string name = load[0];
                   // CoffeeShopBL s = new CoffeeShopBL(name);
                   orders.Add(name);
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
